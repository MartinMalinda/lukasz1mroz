using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class HomeController : Controller
    {
        List<Shopitem> shopItems = new List<Shopitem>()
        {
            new Shopitem("Running shoes", "Nike running shoes for everyday sport", 1000.0, 5),
            new Shopitem("Printer", "Some HP printer that will print pages", 3000.0, 2),
            new Shopitem("Coca cola", "0.5 l standard coke", 25.0, 0),
            new Shopitem("Wokin", "Chicken in fried rice and wokin sauce", 119.0, 100),
            new Shopitem("T-shirt", "Blue with a corgi on a bike", 300.0, 1)
        };

        public ActionResult Index(string submit, string searchString)
        {
            switch (submit)
            {
                case "ONLY AVAILABLE":
                    var onlyAvailable = shopItems.Where(item => item.QuantityOfStock > 0);
                    ViewBag.Items = onlyAvailable;
                    return View();
                case "CHEAPEST FIRST":
                    var cheapestFirst = shopItems.OrderBy(item => item.Price);
                    ViewBag.Items = cheapestFirst;
                    return View();
                case "CONTAINS NIKE":
                    var containsNike = shopItems.Where(item => item.Description.Contains("Nike"));
                    ViewBag.Items = containsNike;
                    return View();
                case "MOST EXPENSIVE":
                    var mostExpensive = shopItems.OrderByDescending(item => item.Price).First();
                    IEnumerable<Shopitem> mostExpensiveIE = new[] { mostExpensive };
                    ViewBag.Items = mostExpensiveIE;
                    return View();
                case "AVERAGE STOCK":
                    var average = shopItems.Average(item => item.QuantityOfStock);
                    ViewBag.Items = average;
                    return View("~/Views/Home/Average.cshtml");
                case "SEARCH":
                    var searchProducts = shopItems.Where(item => item.Name.Contains(searchString) || item.Description.Contains(searchString));
                    ViewBag.Items = searchProducts;
                    return View();
                default:
                    ViewBag.Items = shopItems;
                    return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
