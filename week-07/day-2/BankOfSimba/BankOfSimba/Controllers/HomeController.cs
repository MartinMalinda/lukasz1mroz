using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        static List<BankAccount> accountsList = new List<BankAccount>()
        {
            new BankAccount("Tim", 750, "monkey", false, false),
            new BankAccount("Paul", 1750, "parrot", false, false),
            new BankAccount("John", 120, "turtle", false, true),
            new BankAccount("Jenny", 2250, "zebra", false, true),
            new BankAccount("Clark", 230, "bug", false, false),
            new BankAccount("Simba", 230, "lion", true, false)
        };
        public IActionResult Index()
        {
            return View();
        }

        [Route("/show")]
        public IActionResult Show()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "lion", false, false);
            return View(bankAccount);
        }

        [Route("/string")]
        public IActionResult String()
        { 
            ViewBag.Text = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View();  
        }

        [Route("/accounts")]
        public IActionResult Accounts()
        {

            ViewBag.Items = accountsList;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
