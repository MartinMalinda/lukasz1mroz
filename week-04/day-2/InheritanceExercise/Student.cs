using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.PreviousOrganization = previousOrganization;
        }

        public Student()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.PreviousOrganization = "The School of Life";
            this.SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.SkippedDays += numberOfDays;
        }
    }
}
