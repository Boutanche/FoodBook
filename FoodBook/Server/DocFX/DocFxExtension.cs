using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocFX.AspNetCore
{
    public static class DocFxExtension
    {
        /// <summary>
        /// Ajouter middleware Server static files
        /// </summary>
        /// <param name="app"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseDocFx(this IApplicationBuilder app, Action<DocFxSettings> configure)
        {
            //Options de configuration
            DocFxSettings settings = new DocFxSettings();
            if (configure == null)
            {
                settings.rootPath = "/docfx";
            }
            else
            {
                configure.Invoke(settings);
            }
            //END Option de config.

            //servir les fichiers statiques sur le rootPath
            app.UseFileServer(new FileServerOptions {

                RequestPath = new PathString(settings.rootPath),
                FileProvider = new EmbeddedFileProvider(typeof(DocFxExtension).GetTypeInfo().Assembly, "DocFX._site")
            });

            return app;
        }
    }
}
