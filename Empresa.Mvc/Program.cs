using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Empresa.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration() // Aqui sería alterado para indicar qual é o servidor apache, etc para subir a aplicação, ele é ignorado o alterado
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
