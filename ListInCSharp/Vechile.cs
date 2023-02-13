using System;
using System.Collections.Generic;
using System.Text;

namespace ListInCSharp
{
    public class Vechile
    {
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Tiers { get; set; }
        public string Speed { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("All Common Properties for Vechile");
        }
    }
}
