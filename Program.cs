using DashboardApi;
using DashboardApi.Mail;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.EntityFrameworkCore;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var defaultconnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionString = builder.Configuration.GetConnectionString("DBREBELWINGS");
var connectionStringBD1 = builder.Configuration.GetConnectionString("DB1");
var connectionStringBD2 = builder.Configuration.GetConnectionString("DB2");

builder.Services.AddDbContext<DBRebelContext>(options => options.UseSqlServer(connectionString))
    .AddDbContext<BD1Context>(options => options.UseSqlServer(connectionStringBD1))
    .AddDbContext<DashboardContext>(options => options.UseSqlServer(defaultconnectionString))
    .AddDbContext<BD2Context>(options => options.UseSqlServer(connectionStringBD2));

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod())
);


builder.Services.AddScoped<MailC>();
builder.Services.AddScoped<Funciones>();

//// Configurar Quartz
//builder.Services.AddQuartz(q =>
//{
//    // Just use the name of your job that you created in the Jobs folder.
//    var jobKey = new JobKey("SendEmailJob");
//    q.AddJob<MainJobs>(opts => opts.WithIdentity(jobKey));

//    q.AddTrigger(opts => opts
//        .ForJob(jobKey)
//        .WithIdentity("SendEmailJob-trigger")
//        .WithSimpleSchedule(x => x
//            .WithIntervalInMinutes(30) // Intervalo de 30 minutos
//            .RepeatForever()) // Se repite indefinidamente
//    );
//});


//builder.Services.AddQuartz(q =>
//{
//    // Just use the name of your job that you created in the Jobs folder.
//    var jobKey = new JobKey("SendEmailJobMermas");
//    q.AddJob<MainJobs>(opts => opts.WithIdentity(jobKey));

//    q.AddTrigger(opts => opts
//        .ForJob(jobKey)
//        .WithIdentity("SendEmailJobMermas-trigger")
//        //This Cron interval can be described as "run every minute" (when second is zero)  
//        .WithCronSchedule("0 42 8 * * ?")
//    );
//});

//builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwaggerUI(c =>
{
    app.UseSwagger().UseDeveloperExceptionPage();
#if DEBUG
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API DASHBOARD v1");
#else
    c.SwaggerEndpoint("/back/api_planeacion/swagger/v1/swagger.json", "API_PEDIDOS v1");
#endif
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
