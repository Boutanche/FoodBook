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
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using System.Diagnostics;

namespace API
{
    public class Startup
    {
        /// <summary>
        /// Point d'entrée pour la configuaration de l'API
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;   
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*************************************************************************
             * 
             * But Pédagogique : 
             * AddTrasient ou AddScoped .
             * 
             * 
            //Unique dans toute mon application (même instance dans toute l'aplication)
            //A chaque fois qu'on demande un Ilibrairi service => nouvelle instance
            //services.AddTransient<IRestaurantService, RestaurantService>();
            
            // La même instance tout au long de la requête
            //services.AddScoped<ILibrairiService, LibrairiService>();
            ***************************************************************************/
            
            //Service de Versionning
            services.AddApiVersioning(config =>
            {
                //Renvoie dans le header les versions d'API supportées.
                config.ReportApiVersions = true;
            });

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
            //Authentification : 
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                Trace.WriteLine("Service : Mise en place de Authentification  ");
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = Configuration["JwtIssuer"],
                    ValidAudience =  Configuration["JwtIssuer"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
                    //
                    ClockSkew = TimeSpan.Zero //Remove delay of token when expire.
                };
            });
            //Controllers :
            services.AddControllers();
            //BLL :
            services.AddBLL();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                Trace.WriteLine("Seulement en environnement de développement : ");
                Trace.WriteLine("Utilisation de la page d'exception pour les développeurs.");
                app.UseDeveloperExceptionPage();

            }
            /***            ***
             *                *
             * Middleware     *
             *                *
             ***              */
            
            //DocFX
            app.UseDocFx(config =>
            {
                config.rootPath = "/doc";
            });

            //OpenAPIjson
            app.UseOpenApi(config =>
            {
                config.Path = "/api/doc/{documentName}/api.json";
            });

            // Interface utilisateur en fonction du OpenApi.json : Swagger
            app.UseSwaggerUi3(config =>
            {
                config.DocumentPath = "/api/doc/{documentName}/api.json";
                config.Path = "/api/doc";
            });

            //Https :
            app.UseHttpsRedirection();
            
            //Routes
            app.UseRouting();
            
            //CE : 403
            app.UseAuthorization();

            //CE : 401
            app.UseAuthentication();
            
            //Mapping
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
