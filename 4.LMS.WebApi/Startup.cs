using _1.LMS.Application;
using _3.LMS.Infrastructure;
using _4.LMS.WebApi.ConfigureServices;
using _4.LMS.WebApi.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _4.LMS.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // add Core Application Layer Container
            services.AddApplicationLayerServices();
            // add Core Persistence Layer Container
            services.AddPersistenceLayerServices(Configuration);

            // Add Identity ConfigureServices
            services.AddIdentityService();

            // Add Authentication
            services.AddAuthenticationService(Configuration);

            // Add Authorization
            services.AddAuthorizationService();

            // Add Swagger

            services.AddSwaggerGenService();

            services.AddControllers();

            //-----------------------------------
            // services.AddAutoMapper(typeof(Startup));
            // services.AddMediatR(typeof(Startup));
            // -------------------------------
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "_4.LMS.WebApi v1"));
            }

            // Add Golable ExceptionHandler in Prodaction mode
            app.UseGolableExceptionMiddleware();

            app.UseHttpsRedirection();

            app.UseRouting();

            // add authentication Midllware
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}