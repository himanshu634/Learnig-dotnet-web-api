using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace demo_api
{
    public class Program
    {
        public static void Main(string[] args){
         CreateHostBuilder().Build().Run();
      }

      public static IHostBuilder CreateHostBuilder(){
        return  Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHost => 
        {
           webHost.UseStartup<Startup>();
        });
      }
    }
}
