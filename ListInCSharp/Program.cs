using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            var student = new Student()
            {
                Id= x,
                Name = "Shakib",
                Program ="CSE",
                BloodGroup = "A+",
                Mobile = "0175XXXXX",
                Course = new Course()
                {
                    Id = 1,
                    Name = "Bangla"
                }
            };

            Console.WriteLine($"Name: {student.Name} \nID: {student.Id} \nProgram: " +
                $"{student.Program} \nCourse: {student.Course.Name}");

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string BloodGroup { get; set; }
        public string Program { get; set; }
        public Course Course { get; set; }

    }

    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
