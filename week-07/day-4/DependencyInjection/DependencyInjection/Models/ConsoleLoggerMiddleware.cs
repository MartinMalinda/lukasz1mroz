using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace DependencyInjection.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware 
    {
        private Printer printer;
        private IColor iColor;
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("Sample message");
            iColor.PrintColor();

            return next(context);
        }
        
        public ConsoleLoggerMiddleware(Printer printer, IColor iColor)
        {
            this.printer = printer;
            this.iColor = iColor;
        }
    }
}
// CLM depends o IColor interface which is injected into constructor
// Dependency I