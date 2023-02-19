using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBanking
{
    public class Borrwer
    {
        public string LoanNo { get; set; }
        public decimal LoanAmount { get; set; }
        public Customer Customer { get; set; }
    }
}
