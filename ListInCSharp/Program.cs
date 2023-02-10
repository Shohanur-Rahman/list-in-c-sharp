using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Rafiq Ahmed",
                "Riad",
                "Tamim",
                "Rafiq Islam"
            };

            var rafiq = names.Where(x => x.Contains("Rafiq"));

            foreach(var name in rafiq)
            {
                Console.WriteLine(name);
            }

        }
    }
}
