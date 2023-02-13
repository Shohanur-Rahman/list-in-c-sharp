using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBanking
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public List<Depositor> Depositors { get; set; }
    }
}
