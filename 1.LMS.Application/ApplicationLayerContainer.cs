using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace _1.LMS.Application
{
    public static class ApplicationLayerContainer
    {
        public static IServiceCollection AddApplicationLayerServices(this IServiceCollection service)
        {
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddMediatR(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}
