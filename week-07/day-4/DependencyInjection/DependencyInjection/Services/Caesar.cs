using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Services
{
    public class Caesar : ICaesar
    {
        public string Decoder(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }
    }
}
