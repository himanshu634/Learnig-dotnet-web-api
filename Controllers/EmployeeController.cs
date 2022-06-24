using Microsoft.AspNetCore.Mvc;
using demo_api.models;
using System.Collections.Generic;

namespace demo_api.Controllers {

   [Route("api/[controller]")]
   public class EmployeeController : ControllerBase
   {

      [Route("")]
      public List<EmployeeModel> GetAllEmployee()
      {
         return new List<EmployeeModel>() {
            new EmployeeModel(){ Id = 23, Name = "John" },
            new EmployeeModel() {Id=24, Name= "Ronil"} };
      }

      [Route("{id}")]
      public IActionResult GetEmployee(int id){

         if(id == 0){
            return NotFound();
         }
         return Ok(
            new List<EmployeeModel>() {
               new EmployeeModel(){ Id = 23, Name = "John" },
               new EmployeeModel() {Id=24, Name= "Ronil"} 
            });

      }

      [Route("{id}/basic")]
      public ActionResult<EmployeeModel> GetEmployeeDetail(int id)
      {

         if (id == 0)
         {
            return NotFound();
         }
         return new EmployeeModel() { Id = 23, Name = "John" };

      }

   }
}