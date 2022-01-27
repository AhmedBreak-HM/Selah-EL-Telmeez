using _1.LMS.Application.Contracts;
using _3.LMS.Infrastructure.Data;
using _3.LMS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure
{
    public static class PersistenceLayerContainer
    {
        public static IServiceCollection AddPersistenceLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();


            return services;
        }
    }
}
