using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
using Microsoft.IdentityModel.Tokens;
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
            ConfigureServiceOpenApi(services);
            ConfigureServiceDbContext(services);
            ConfigureServiceIdentity(services);
            ConfigureServiceVersioning(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        #region Config ADD
        private void ConfigureServiceOpenApi(IServiceCollection services)
        {
            services.AddSwagger();
        }
        private void ConfigureServiceDbContext(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
        }
        private void ConfigureServiceIdentity(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
                                                                 .AddDefaultTokenProviders();

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



            // This returns 401 when a user isn't logged in, instead of redirecting to login page!
            // https://stackoverflow.com/questions/38800919/how-to-return-401-instead-of-302-in-asp-net-core
            services.ConfigureApplicationCookie(options =>
            {
                options.Events.OnRedirectToLogin = context =>
                {
                    context.Response.StatusCode = 401;
                    return Task.CompletedTask;
                };
            });


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = "http://oec.com",
                    ValidIssuer = "http://oec.com",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"))
                };
            });



        }
        private void ConfigureServiceVersioning(IServiceCollection services)
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
                ConfigureUseSwagger(app, env); // Do not expose Swagger interface in production
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

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

        #region Config USE
        public void ConfigureUseSwagger(IApplicationBuilder app, IHostingEnvironment env)
        {
            string descr = "My tutorial on how to build web Api's";
            string title = "WebApiToken Demo";

            //app.UseSwaggerUiWithApiExplorer(settings =>
            app.UseSwaggerUi(typeof(Startup).GetTypeInfo().Assembly, settings =>
            {
                settings.SwaggerRoute = "/swagger/v3/swagger.json";
                settings.ShowRequestHeaders = true;
                settings.DocExpansion = "list";
                settings.UseJsonEditor = true;
                settings.PostProcess = document =>
                {
                    document.BasePath = "/";
                };
                settings.GeneratorSettings.Description = descr;
                settings.GeneratorSettings.Title = title;
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
                settings.GeneratorSettings.Description = descr;
                settings.GeneratorSettings.Title = title;
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
                settings.GeneratorSettings.Description = descr;
                settings.GeneratorSettings.Title = title;
                settings.GeneratorSettings.Version = "1.0";
                settings.GeneratorSettings.OperationProcessors.Add(
                    new ApiVersionProcessor() { IncludedVersions = new[] { "1.0" } }
                );
            });
        }
        #endregion
    }
}
