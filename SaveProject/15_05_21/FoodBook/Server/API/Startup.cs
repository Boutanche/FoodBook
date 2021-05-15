
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Services;
using DocFX;
using DocFX.AspNetCore;

namespace API
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

            //Unique dans toute mon application (même instance dans toute l'aplication)
            ////A chaque fois qu'on demande un Ilibrairi service => nouvelle instance
            //services.AddTransient<IRestaurantService, RestaurantService>();
            //// La même instance tout au long de la requête
            //services.AddScoped<ILibrairiService, LibrairiService>();

            //Service de Versionning
            services.AddApiVersioning(config =>
            {
                //Renvoie dans le header les versions d'API supportées.
                config.ReportApiVersions = true;
            });
            //Correction de Bug 

            services.AddVersionedApiExplorer(options =>
            {
                options.SubstituteApiVersionInUrl = true;
            });

            // Documentation Client API
            services.AddOpenApiDocument(config =>
            {
                config.DocumentName = "v1.0";
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1.0";
                    document.Info.Title = "FoodBook Public API Connector";
                    document.Info.Description = "A simple ASP.NET Core web API";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Benoit BERTRAND CDA03",
                        Email = string.Empty,
                        Url = "www.bbinformatique.fr"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = ""
                    };
                };
                config.ApiGroupNames = new[] { "1.0" };
            });
            //End OpenAPI Document

            services.AddControllers();
            services.AddBLL();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            //DocFX
            app.UseDocFx(config =>
            {
                config.rootPath = "/doc";
            });

            //Middleware de génération du OpenAPIjson
            app.UseOpenApi(config =>
            {
                config.Path = "/api/doc/{documentName}/api.json";
            });
            //END

            // Interface utilisateur en fonction du OpenApi.json
            app.UseSwaggerUi3(config =>
            {
                config.DocumentPath = "/api/doc/{documentName}/api.json";
                config.Path = "/api/doc";
            });
            //END

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
