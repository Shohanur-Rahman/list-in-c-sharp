using System;

namespace MyConditionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age  = Convert.ToInt32(Console.ReadLine());
            string message = string.Empty;

            message = (age >= 18) ? "You are young man" : "You are a child";

            Console.WriteLine(message);

        }
    }
}
