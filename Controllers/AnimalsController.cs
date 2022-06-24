using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using demo_api.models;
using System.Linq;
using System;

namespace demo_api.Controllers {

   [Route("api/[controller]")]
   public class AnimalsController : ControllerBase {

      List<AnimalModel> animals = null;
      public AnimalsController() {
         animals = new List<AnimalModel>() {
               new AnimalModel(){ id=12, name="Dog"},
               new AnimalModel(){ id=13, name="Cat"},
         };
      }

      [Route("", Name = "All")]
      public IActionResult GetAnimals(){
         return Ok(animals);
      }

      [Route("test")]
      public IActionResult GetAnimalTest()
      {
         return Accepted("done");
      }

      [Route("{name}")]
      public IActionResult GetAnimalByName(string name){
         if(name.Equals("ABC")){
            return BadRequest();
         }

         return AcceptedAtRoute("All");
      }


      [Route("{id:int}")]
      public IActionResult GetAnimalById(int id) {
         if(id == 0){
            return BadRequest();
         }

         return Ok(animals.FirstOrDefault(x => x.id == id));
      }

//!some error while passing animal object
      [HttpPost("post")]
      public IActionResult AddAnimal(AnimalModel animal){
         //it is not passing animal object to AddAnimal

         // animal = new AnimalModel()
         // {
         //    id = 23,
         //    name = "from add animal",
         // };
         animals.Add(animal);


         return Created("~/api/animals/"+animal.id,animal);
      }


      [Route("redirect")]
      public IActionResult Redirect(){
         return LocalRedirectPermanent("~/api/animals");
      }

      [Route("not-found")]
      public IActionResult NotFoundFile(){
         return NotFound();
      }
   }
}