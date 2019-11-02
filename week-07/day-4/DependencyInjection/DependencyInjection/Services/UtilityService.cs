using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Models
{
    public class UtilityService : IUtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public string ValidateEmail(string email)
        {
            string response = "";

            if (email.Contains("@") && email.Contains("."))
            {
                response = $"<p style=\"color:green\"> {email} is a valid email address.</p>";
            }
            else
            {
                response = $"<p style=\"color:red\"> {email} is not valid email address.</p>";
            }
            return response;
        }
    }
}
