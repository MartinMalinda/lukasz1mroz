using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    public class Person
    {

        string name;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        string goal = "Live for the moment!";

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year {Gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine($"My goal is:{goal}");
        }

    }
}
