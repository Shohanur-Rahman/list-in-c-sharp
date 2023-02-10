using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students= new List<Student>();

            for (int i = 0; i < 5; i++)
            {
                Student student = new Student()
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    Name = Console.ReadLine()
                };

                students.Add(student);
            }

            Console.WriteLine("ID \t Name \t");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} \t {student.Name} \t");
            }

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string BloodGroup { get; set; }
        public string Program { get; set; }
    }
}
