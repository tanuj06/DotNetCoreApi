

namespace CGMMiddleWare.MiddleWare
{
    //all http requests go first throught middleware service
    public class MiddlewareService : IMiddleware
    {
        //entry point for any http request, we can validate http requests here and pass on the request to next middleware(if any)
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var controllerName = context.Request.RouteValues["controller"]?.ToString();
            var actionName = context.Request.RouteValues["action"]?.ToString();
            if (controllerName == "LogOn" && actionName == "LogOn")
            {
                // If the request path matches, skip the execution of the middleware pipeline
                await next(context);
                return;
            }

            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsJsonAsync("Access forbidden. Wrong header");
                return;
            }

            await next(context);
        }
    }
}
