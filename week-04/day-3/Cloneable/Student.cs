using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }
        string goal = "Be a junior software developer.";

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;

            this.PreviousOrganization = previousOrganization;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        public override void GetGoal()
        {

            Console.WriteLine($"My goal is: {goal}");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
        }
    }
}
