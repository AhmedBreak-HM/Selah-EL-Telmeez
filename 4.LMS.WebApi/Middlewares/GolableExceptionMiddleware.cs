using _4.LMS.WebApi.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace _4.LMS.WebApi.Middlewares
{
    public static class GolableExceptionMiddleware
    {
        public static IApplicationBuilder UseGolableExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(BuilderExtensions => BuilderExtensions.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var error = context.Features.Get<IExceptionHandlerFeature>();
                if (error != null)
                {
                    context.Response.AddApplicationError(error.Error.Message);
                    await context.Response.WriteAsync(error.Error.Message);
                    await context.Response.WriteAsync(error.Error.StackTrace);
                }
            }));
            return app;
        }
    }
}