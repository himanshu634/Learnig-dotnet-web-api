using Microsoft.AspNetCore.Mvc;

namespace demo_api.Controllers {

   [ApiController]
   [Route("api/{controller}")]
   public class BooksController : ControllerBase {

      [Route("{id:int:min(10)}")] // type constraint
      public string GetById(int id){
         return "Hello int" + id;
      }

      [Route("{id:minLength(3):alpha}")]
      public string GetByIdString(string id){
         return "Hello string" + id;
      }

      [Route("{id:regex(a(b|c))}")]
      public string GetByIdregex(string id)
      {
         return "Hello regex" + id;
      }
   }
}