using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    // Having main route at useful and under it separate routes for different utilities
    [Route("")]
    [Route("useful")]
    public class UtilityController : Controller
    {
        // Adding utility service as dependency of controller
        private IUtilityService utilityService;
        private ICaesar caesar;
        public UtilityController(IUtilityService utilityService, ICaesar caesar)
        {
            this.utilityService = utilityService;
            this.caesar = caesar;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("colored")]
        public IActionResult Colored()
        {
            string color = utilityService.RandomColor();
            return View(color);
        }

        [HttpGet("email")]
        public IActionResult Email(string email, UtilityService utilityService)
        {
            ViewData["result"] = utilityService.ValidateEmail(email);
            return View();
        }

        [HttpGet("encode")]
        public IActionResult Encode(string text, int number)
        {
            ViewData["encoded"] = caesar.Decoder(text, number);
            return View();
        }

        [HttpGet("decode")]
        public IActionResult Decode(string text, int number)
        {
            ViewData["decoded"] = caesar.Decoder(text, number);
            return View();
        }
    }
}