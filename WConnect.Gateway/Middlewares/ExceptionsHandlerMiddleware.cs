using System.Net;
using System.Text.Json;

namespace WConnect.Gateway.Middlewares;

public class ExceptionsHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _log;

    public ExceptionsHandlerMiddleware(RequestDelegate next, ILoggerFactory log){
        this._next = next;
        this._log = log.CreateLogger("Gateway");
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (BadHttpRequestException exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = exception.StatusCode;
            await httpContext.Response.WriteAsJsonAsync(new {
                exception.Message
            });
        }
        catch(Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            await httpContext.Response.WriteAsJsonAsync(new {
                exception.Message
            });
        }
    }
}
