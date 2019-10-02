using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an instance of John, 20, male, BME
            // Clone him into JohnTheClone

            var studentJohn = new Student("John", 20, "male", "BME");
            Student johnTheCopy = (Student)studentJohn.Clone();
            studentJohn.Introduce();
            johnTheCopy.Introduce();
        }
    }
}
