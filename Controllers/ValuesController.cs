using Microsoft.AspNetCore.Mvc;

namespace demo_api.Controllers{

   // [Route("api/[controller]")]
   [ApiController]
   [Route("[controller]/[action]")]

   public class ValuesController : ControllerBase {

      // [Route("get-all")]
      [Route("~/getall")] // will override the controller/action route
      public string GetAll(){
         return "Hello from get all";
      }

      // [Route("get-all-authors")]
      //![Route("getall")] -> not possible
      public string GetAllAuthors(){
         return "Hello from get all authors";
      }

      [Route("{id}")]
      // [Route("books/{bookId}/author/{authorId}")]
      public string GetBook(int id){
         return "Hwllo " + id;
      }

      // [Route("search")]
      // url like localhost:5000/search?id=1&price=2000&name=homo-sapiens&author=yuval
      public string Search(int id, int price, string name, string author){
         return "Search book with id " + id;
      }
   }
}