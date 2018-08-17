using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NSwag.AspNetCore;
using NSwag.SwaggerGeneration.Processors;
using WebApiTokenDemo.Data;


namespace WebApiTokenDemo
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
            ConfigureOpenApi(services);
            ConfigureDbContext(services);
            ConfigureIdentity(services);
            ConfigureVersioning(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        #region Config services
        private void ConfigureOpenApi(IServiceCollection services)
        {
            services.AddSwagger();
        }
        private void ConfigureDbContext(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
        }
        private void ConfigureIdentity(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            //services.AddDefaultIdentity<ApplicationUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //    {
            //        // Password settings
            //        options.Password.RequireDigit = true;
            //        options.Password.RequiredLength = 8;
            //        options.Password.RequiredUniqueChars = 2;
            //        options.Password.RequireLowercase = true;
            //        options.Password.RequireNonAlphanumeric = true;
            //        options.Password.RequireUppercase = true;

            //        // Lockout settings
            //        options.Lockout.AllowedForNewUsers = true;
            //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //        options.Lockout.MaxFailedAccessAttempts = 5;

            //        // Signin settings
            //        options.SignIn.RequireConfirmedEmail = true;
            //        options.SignIn.RequireConfirmedPhoneNumber = false;

            //        // User settings.
            //        options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            //        options.User.RequireUniqueEmail = false;
            //    })
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();
        }
        private void ConfigureVersioning(IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                //options.DefaultApiVersion = new ApiVersion(1, 0);
                //options.AssumeDefaultVersionWhenUnspecified = true;
                // Includes headers "api-supported-versions" and "api-deprecated-versions"
                options.ReportApiVersions = true;
            });

            // Alternative to attribute based versioning
            //options.Conventions.Controller<GameServerController>()
            //    .HasDeprecatedApiVersion(new ApiVersion(0, 9))
            //    .HasApiVersion(1)
            //    .AdvertisesApiVersion(2)
            //    .Action(a => a.Get(default(int))).MapToApiVersion(1);

        }
        #endregion


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwaggerUiWithApiExplorer(settings =>
                {
                    settings.SwaggerRoute = "/swagger/v3/swagger.json";
                    settings.ShowRequestHeaders = true;
                    settings.DocExpansion = "list";
                    settings.UseJsonEditor = true;
                    settings.PostProcess = document =>
                    {
                        document.BasePath = "/";
                    };
                    settings.GeneratorSettings.Description = "Building Web APIs Workshop Demo Web API";
                    settings.GeneratorSettings.Title = "Genealogy API";
                    settings.GeneratorSettings.Version = "3.0";
                    settings.GeneratorSettings.OperationProcessors.Add(
                        new ApiVersionProcessor() { IncludedVersions = new[] { "3.0" } }
                    );
                });
                app.UseSwaggerUiWithApiExplorer(settings =>
                {
                    settings.SwaggerRoute = "/swagger/v2/swagger.json";
                    settings.ShowRequestHeaders = true;
                    settings.DocExpansion = "list";
                    settings.UseJsonEditor = true;
                    settings.PostProcess = document =>
                    {
                        document.BasePath = "/";
                    };
                    settings.GeneratorSettings.Description = "Building Web APIs Workshop Demo Web API";
                    settings.GeneratorSettings.Title = "Genealogy API";
                    settings.GeneratorSettings.Version = "2.0";
                    settings.GeneratorSettings.OperationProcessors.Add(
                        new ApiVersionProcessor() { IncludedVersions = new[] { "2.0" } }
                    );
                });
                app.UseSwaggerUiWithApiExplorer(settings =>
                {
                    settings.SwaggerRoute = "/swagger/v1/swagger.json";
                    settings.ShowRequestHeaders = true;
                    settings.DocExpansion = "list";
                    settings.UseJsonEditor = true;
                    settings.PostProcess = document =>
                    {
                        document.BasePath = "/";
                    };
                    settings.GeneratorSettings.Description = "Building Web APIs Workshop Demo Web API";
                    settings.GeneratorSettings.Title = "Genealogy API";
                    settings.GeneratorSettings.Version = "1.0";
                    settings.GeneratorSettings.OperationProcessors.Add(
                        new ApiVersionProcessor() { IncludedVersions = new[] { "1.0" } }
                    );
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            //app.UseAuthentication();

            IServiceProvider serviceProvider = app.ApplicationServices
                                                  .GetRequiredService<IServiceScopeFactory>()
                                                  .CreateScope()
                                                  .ServiceProvider;

            SeedDatabase.Initialize(serviceProvider);

            app.UseMvc();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "areas",
            //        template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            //    );
            //});
        }
    }
}
