using Microsoft.AspNetCore.Mvc;
using demo_api.models;
using System.Collections.Generic;
using System.Linq;

namespace demo_api.Controllers
{


   [ApiController]
   [Route("api/[controller]")]
   public class AssignmentController : ControllerBase
   {
      List<PersonModel> persons = null;

      public AssignmentController()
      {
         persons = new List<PersonModel>(){
            new PersonModel() { Id = 1, Name = "Himanshu" },
            new PersonModel() { Id = 2, Name = "Ronil" }
         };
      }

      [Route("")]
      public IActionResult GetData()
      {
         return Ok(persons);
      }

      [Route("add")]
      public IActionResult Add(int first, int second){
         return Ok(first + second);
      }

      [Route("multiply")]
      [HttpPost]
      //!struggling with post
      public IActionResult Multiply(int first, int second){
         return Ok(first * second);
      }

      [Route("sub")]
      [HttpPut]
      public IActionResult Subtract(int first, int second){
         return Ok(first - second);
      }


      [Route("delete")]
      [HttpPut]
      public IActionResult Delete(int first, int second){
         return Ok("deleted");
      }


   }
}
