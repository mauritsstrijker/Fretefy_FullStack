using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Services;
using Fretefy.Test.Application.Settings;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Infra.EntityFramework;
using Fretefy.Test.Infra.EntityFramework.Interceptors;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Fretefy.Test.Infra.Services;
using Fretefy.Test.WebApi.HostedServices;
using Fretefy.Test.WebApi.Middlewares;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fretefy.Test.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AuthSettings>(_configuration.GetSection("Auth"));
            services.Configure<GoogleSettings>(_configuration.GetSection("Google"));

            services.AddScoped<DbContext, TestDbContext>();
            services.AddDbContext<TestDbContext>((provider, options) =>
            {
                options.UseSqlite("Data Source=Data\\Test.db")
                    .AddInterceptors(new EntityIdInterceptor());
            });

            ConfigureInfraService(services);
            ConfigureApplicationServices(services);

            // autenticação cookie http only + strict baseado em access e refresh tokens
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    // apenas para desenvolvimento
                    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                    options.Cookie.Name = "Fretefy.Auth";
                    options.Events.OnRedirectToLogin = context =>
                    {
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        return System.Threading.Tasks.Task.CompletedTask;
                    };
                    options.Events.OnRedirectToAccessDenied = context =>
                    {
                        context.Response.StatusCode = StatusCodes.Status403Forbidden;
                        return System.Threading.Tasks.Task.CompletedTask;
                    };
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(_configuration["Cors:Origins"])
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });

            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
        }

        private void ConfigureInfraService(IServiceCollection services)
        {
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddScoped<IExportService, ExportService>();
            services.AddHttpClient<IGeocodingService, GoogleGeocodingService>();
        }

        private void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IRegiaoService, RegiaoService>();
            services.AddScoped<IRegiaoExportService, RegiaoExportService>();
            services.AddScoped<IAuthService, AuthService>();

            services.AddHostedService<GeocodificacaoHostedService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ConfigureMiddlewares(app);

            app.UseCors();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void ConfigureMiddlewares(IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}