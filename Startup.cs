using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using PortfolioRest.Interface;
using PortfolioRest.Service;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using PortfolioRest.Repository;

namespace PortfolioRest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore()
                .AddApiExplorer();
            
            services.AddSwaggerGen((options) => {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "PotfolioRest", Version = "v1" });
            });

            var connStr = Configuration.GetConnectionString("PortfolioDatabase");
            var _sessionFactory = Fluently.Configure()
                                      .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connStr))
                                      .Mappings(m => m.FluentMappings.AddFromAssembly(GetType().Assembly))
                                      .BuildSessionFactory();
            services.AddScoped(factory =>
            {
                return _sessionFactory.OpenSession();
            });

            services.AddScoped<IPublicacaoService, PublicacaoService>();
            services.AddScoped<IPublicacaoRepository, PublicacaoRepository>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PotfolioRest");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
