using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PortfolioRest.Interface;
using PortfolioRest.Mappings;
using PortfolioRest.Repository;
using PortfolioRest.Service;

namespace _1_Api
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
            services.AddControllers();

            services.AddMvcCore().AddApiExplorer();

            services.AddSwaggerGen((options) => {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "PotfolioRest", Version = "v1" });
            });


            var connectionString = "Server= localhost; Database= Portfolio; Integrated Security=True;";

            var mssqlserver = MsSqlConfiguration.MsSql2012.ConnectionString(connectionString);

            var _sessionFactory = Fluently.Configure()
                .Database(mssqlserver)
                .Mappings(m => { m.FluentMappings.AddFromAssemblyOf<PublicacaoMap>(); })
                .BuildSessionFactory();

            services.AddScoped(factory =>
            {
                return _sessionFactory.OpenSession();
            });


            //INJE��O DE DEPEND�NCIA

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

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
