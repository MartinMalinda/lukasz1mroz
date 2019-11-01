using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Color : IColor
    {
        private string color = "red";

        public void PrintColor()
        {
            Console.WriteLine($"This is {color} in color");
        }
    }
}

