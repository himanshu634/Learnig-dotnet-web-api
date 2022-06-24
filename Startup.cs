using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace demo_api 
{
   public class Startup
   {
      //*important method - 1
      public void ConfigureServices(IServiceCollection services){
         services.AddControllers();
         services.AddTransient<CustomMiddleware1>();

      }

      //* importtant method - 2 
      //* used to configure http request pipeline
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env){


         // app.Map("/himanshu", HandleHimanshu);

         app.UseMiddleware<CustomMiddleware1>();

         app.Use(async (context, next) => {
            await context.Response.WriteAsync("hwllo from use 2 started watchin \n");

            await next();

            await context.Response.WriteAsync("Hwllo from return \n");
         });

         app.Run(async context =>
         {
            await context.Response.WriteAsync("hwllo from run 2\n");
         });

         if(env.IsDevelopment()){
            app.UseDeveloperExceptionPage();
         }

         app.UseRouting();

         app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
         });

      }
      private void HandleHimanshu(IApplicationBuilder app)
      {
         app.Use(async (context, next) =>
         {
            await context.Response.WriteAsync("Hello from himanshu\n");
         });
      }
   }
}