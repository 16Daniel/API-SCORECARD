namespace DashboardApi.Middlewares
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;

            // Ignorar Swagger
            if (path.StartsWithSegments("/swagger"))
            {
                await _next(context);
                return;
            }

            if (!context.Request.Headers.TryGetValue("x-api-key", out var extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsJsonAsync(new { error = "API Key requerida" });
                return;
            }

            var configKey = context.RequestServices
                .GetRequiredService<IConfiguration>()["DashboardApiKey"];

            if (extractedKey != configKey)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsJsonAsync(new { error = "API Key inválida" });
                return;
            }

            await _next(context);
        }
    }
}
