using WConnect.Gateway.Middlewares;

namespace WConnect.Gateway.Configurations;

public static class MiddlewareExtension
{
    public static void ConfigureMiddlewares(this IApplicationBuilder appBuilder)
    {
        appBuilder.UseMiddleware<ExceptionsHandlerMiddleware>();
    }   
}