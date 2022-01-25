using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _1.LMS.Application.Contracts;
using _3.LMS.Infrastructure.Data;
using _3.LMS.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

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
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Add Identity ConfigureServices ------------------------------

            services.AddIdentity<UserApplication, IdentityRole>(option =>
            {
                option.Password.RequireDigit = false;
                option.Password.RequiredLength = 6;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireUppercase = false;
                option.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
              .AddDefaultTokenProviders();

            // ------------------------------------------------------------------------------
            //       Add Authentication
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("JWT:TokenKey").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });
            //-----------------------------------------------------------

            //       Add Authorization
            services.AddAuthorization(
                options =>
                {
                    options.AddPolicy("RequireMemberRole", policy => policy.RequireRole("Member"));
                    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                    options.AddPolicy("ModeratePhotoRole", policy => policy.RequireRole("Admin", "Moderator"));
                    options.AddPolicy("VipOnly", policy => policy.RequireRole("VIP"));
                }
            );
            //-----------------------------------
            services.AddControllers();
            // Swagger --------------------------

            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please Bearer and then token in the field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                       }
                      },
                      new string[] { }
                    }
                });
            });

            //-----------------------------------
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