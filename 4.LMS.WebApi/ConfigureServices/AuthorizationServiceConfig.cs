using Microsoft.Extensions.DependencyInjection;

namespace _4.LMS.WebApi.ConfigureServices
{
    public static class AuthorizationServiceConfig
    {
        public static IServiceCollection AddAuthorizationService(this IServiceCollection service)
        {
            service.AddAuthorization(
                options =>
                {
                    options.AddPolicy("RequireStudentRole", policy => policy.RequireRole("Student"));
                    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                    options.AddPolicy("ModerateGuideRole", policy => policy.RequireRole("Teacher", "Parent"));
                }
            );
            return service;
        }
    }
}