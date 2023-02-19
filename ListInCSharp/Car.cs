using System;
using System.Collections.Generic;
using System.Text;

namespace ListInCSharp
{
    public class Car : Vechile , Design
    {
        public string Model { get ; set; }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
    }
}
