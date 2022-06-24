using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demo_api.Controllers
{
   [ApiController]
   [Route("testing/[action]")]
   public class TestController : ControllerBase {
      public string Get() {
         return "Hello from get";
      }

      public string Get1() {
         return "Hwllo from get1";
      }
   }
}