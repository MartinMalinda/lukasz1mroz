using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor(string name, int age,  string gender, string level)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Level = level;
        }

        public Mentor()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }
    }
}
