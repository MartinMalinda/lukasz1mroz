using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExercise
{
    class Cohort
    {
        string Name { get; set; }
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        //Cohort(name) : beside the given parameter, it sets students and mentors as empty lists
        public Cohort(string name)
        {
            this.Name = name;
            List<Student> students = new List<Student>();
            List<Mentor> mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"{Name} has {students.Count} students and {mentors.Count} mentors");
        }
    }
}
