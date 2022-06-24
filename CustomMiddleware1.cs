using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace demo_api{
   public class CustomMiddleware1 : IMiddleware {
      public async Task InvokeAsync(HttpContext context, RequestDelegate next){
         await context.Response.WriteAsync("Hwllo from file 1 \n");

         await next(context);

         await context.Response.WriteAsync("Returning from file 1\n");
      }

   }
}