using CorePush.Apple;
using CorePush.Google;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using net_core_api_push_notification_demo.Models;
using net_core_api_push_notification_demo.Services;
using ProjectServiceEZATU.Manager.activity;
using ProjectServiceEZATU.Manager.home;
using ProjectServiceEZATU.Manager;
using ProjectServiceEZATU.Service.Interface.activity;
using ProjectServiceEZATU.Service.Interface.home;
using ProjectServiceEZATU.Service.Interface;
using System;
using WebApplication.Models;
using CorePush.Apple;
using CorePush.Google;
using ProjectServiceEZATU.Manager;
using ProjectServiceEZATU.Manager.activity;
using ProjectServiceEZATU.Manager.home;
using ProjectServiceEZATU.Service.Interface;
using ProjectServiceEZATU.Service.Interface.activity;
using ProjectServiceEZATU.Service.Interface.home;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using net_core_api_push_notification_demo.Models;
using net_core_api_push_notification_demo.Services;
using System.IO;
using WebApplication.Extensions;
using WebApplication.Models;
using Wkhtmltopdf.NetCore;

namespace ProjectServiceEZATU
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseIISIntegration();
                    webBuilder.UseStartup<Startup>();
                });

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
                services.AddSingleton<DapperContext>();
                services.AddScoped<IActivity, ActivityMa>();
                services.AddScoped<IHome, HomeMa>();
                services.AddJWTTokenServices(Configuration);
                services.AddTransient<INotificationService, NotificationService>();
                services.AddHttpClient<FcmSender>();
                services.AddHttpClient<ApnSender>();

                services.AddControllers();
                services.AddWkhtmltopdf("wkhtmltopdf");
                services.AddSwaggerGen(c =>
                {
                    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                        Description = "JWT Authorization header using the Bearer scheme."
                    });
                    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement {
                {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme {
                    Reference = new Microsoft.OpenApi.Models.OpenApiReference {
                        Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                            Id = "Bearer"
                    }
                },
                    new string[] {}
                }
            });
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Service-EZATU-APP-API", Version = "v1" });
                });

                var appSettingsSection = Configuration.GetSection("FcmNotification");
                services.Configure<FcmNotificationSetting>(appSettingsSection);
                var userRefreshTokens = new System.Collections.Concurrent.ConcurrentDictionary<string, UserTokens>();
                services.AddSingleton(userRefreshTokens);



                services.AddWkhtmltopdf("wkhtmltopdf");

            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseSwagger();
                    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LabelScreeninfo v1"));
                }

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();
                //app.UseRouting();
                app.UseAuthentication();


                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }

        }
    }
}