using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public Greeting(long id, string content, string name)
        {
            this.Id = id;
            this.Content = $"{content}, {name}";
        }

    }
}
