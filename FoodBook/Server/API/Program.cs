using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Trace.WriteLine("... Lancement de l'API FoodBook ..." );

            CreateHostBuilder(args).Build().Run();
            Trace.WriteLine("A des fins pédagogiques, j'ai tendance à laisser des 'TRACES' un peu partout, ne faites pas attention à moi.");
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    Trace.WriteLine("Je suis Ligne 30 de la classe Program.cs");
                });

    }
}
