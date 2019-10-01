using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor(string name, int age, string gender, string company)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
            this.HiredStudents = 0;
        }

        public Sponsor()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.Company = "Google";
            this.HiredStudents = 0;
        }

        public void Hire()
        {
            HiredStudents += 1;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
