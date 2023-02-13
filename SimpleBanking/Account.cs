using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBanking
{
    public class Account
    {
        public string AccountId { get; set; }
        public DateTime OpeningDate { get; set; }
        public Customer Customer { get; set; }
    }
}
