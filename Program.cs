using DashboardApi.Funciones;
using DashboardApi.Jobs;
using DashboardApi.Mail;
using DashboardApi.Middlewares;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var DashboardConnection = builder.Configuration.GetConnectionString("DashboardConnection");
var RebelWingsConnection = builder.Configuration.GetConnectionString("RebelWingsConnection");
var DB1Connection = builder.Configuration.GetConnectionString("DB1Connection");
var DB2Connection = builder.Configuration.GetConnectionString("DB2Connection");

builder.Services.AddDbContext<DBRebelContext>(options => options.UseSqlServer(RebelWingsConnection))
    .AddDbContext<BD1Context>(options => options.UseSqlServer(DB1Connection))
    .AddDbContext<DashboardContext>(options => options.UseSqlServer(DashboardConnection))
    .AddDbContext<BD2Context>(options =>
    options.UseSqlServer(DB2Connection, sqlOptions =>
    {
        sqlOptions.CommandTimeout(3600); // timeout en segundos
    }));

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod())
);


builder.Services.AddScoped<MailC>();
builder.Services.AddScoped<Funciones>();
builder.Services.AddScoped<FuncionesBonos>();

//Configurar Quartz
builder.Services.AddQuartz(q =>
{
    var jobKey = new JobKey("reportebonosjob");
    q.AddJob<Jobreportebonos>(opts => opts.WithIdentity(jobKey));
    q.AddTrigger(opts => opts
        .ForJob(jobKey)
        .WithIdentity("reportebonosjob-trigger")
        .WithCronSchedule("0 0 3 * * ?") 
    );
});

// Quartz como hosted service
builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "RW DashboardApi",
        Version = "v0.0.1",
        Description = "API para administración del dashboard"
    });

    options.AddSecurityDefinition("ApiKey", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = "API Key requerida en el header: x-api-key",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Name = "x-api-key",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new string[] {}
        }
    });
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors();
app.UseMiddleware<ApiKeyMiddleware>();
app.UseAuthorization();
app.MapControllers();

app.Run();
