using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [HttpGet("greeting")] 
        public Greeting SampleGreet(long id, string content, string name)
        {
            Greeting greet = new Greeting(id, "Hello", name);
            return greet;
        }
    }
}