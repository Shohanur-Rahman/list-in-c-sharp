using System;
using System.Collections.Generic;
using System.Linq;

namespace ListInCSharp
{
    internal class Program
    {
        static int noOfAccount;
        static List<Account> accounts = new List<Account>();
        static void Main(string[] args)
        {
            Console.WriteLine("How many Account do you want?");
            noOfAccount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= noOfAccount; i++)
            {
                Account account = new Account()
                {
                    AccountID = (100 + i),
                    OpeningDate = DateTime.Now,
                };

                Customer customer = new Customer();
                Console.WriteLine($"Customer Name: ");
                customer.Name = Console.ReadLine();
                Console.WriteLine($"Customer Mobile: ");
                customer.Mobile = Console.ReadLine();
                Console.WriteLine($"Customer Email: ");
                customer.Email = Console.ReadLine();
                Console.WriteLine($"Customer Address: ");
                customer.Address = Console.ReadLine();
                account.Customer = customer;

                Console.WriteLine("How many amouny you want to deposit");
                List<Depositor> depositors = new List<Depositor>();
                depositors.Add(new Depositor()
                {
                    DepositDate = DateTime.Now,
                    Balance = Convert.ToDecimal(Console.ReadLine()),
                });
                customer.Depositors = depositors;
                accounts.Add(account);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine($"Accountid \t Customer Name \t Email \t Mobile \t Address \t Balance");
            foreach (var item in accounts)
            {
                decimal balance = 0;
                foreach (var deposit in item.Customer.Depositors)
                {
                    balance += deposit.Balance;
                }
                Console.WriteLine($"{item.AccountID} {item.Customer.Name} {item.Customer.Email} " +
                    $" {item.Customer.Mobile} {item.Customer.Address} {balance}");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");

            Console.WriteLine("Which customer want to Deposit?");
            int accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Deposit Amount?");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());


            var depositorAccount = accounts.Where(a => a.AccountID == accountNo).FirstOrDefault();
            if (depositorAccount != null)
            {
                Depositor depositor = new Depositor()
                {
                    DepositDate = DateTime.Now,
                    Balance = depositAmount
                };

                depositorAccount.Customer.Depositors.Add(depositor);
            }
            else
            {
                Console.WriteLine("Account not found");
            }


            foreach (var item in accounts)
            {
                decimal balance = 0;
                foreach (var deposit in item.Customer.Depositors)
                {
                    balance += deposit.Balance;
                }
                Console.WriteLine("\n\n");
                Console.WriteLine($"Accountid \t Customer Name \t Email \t Mobile \t Address \t balance");

                Console.WriteLine($"{item.AccountID} {item.Customer.Name} {item.Customer.Email} " +
                    $" {item.Customer.Mobile} {item.Customer.Address} {balance}");

                //Console.WriteLine("\n\n");
                //Console.WriteLine("\n\n");

            
                
            }
            Console.WriteLine("Which customer do you want to loan?");
            int loanAccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("lone Amount?");
            decimal loanAmount = Convert.ToDecimal(Console.ReadLine());
            var accountForLoan = accounts.Where(a => a.AccountID == loanAccountNumber).FirstOrDefault();
            if (accountForLoan != null)
            {
                Borrower borrower = new Borrower()
                {
                    LoanNumber = 1,
                    LoanAmount = loanAmount,
                };
                if (accountForLoan.Customer.Borrowers == null)
                {
                    accountForLoan.Customer.Borrowers= new List<Borrower>();
                }
                accountForLoan.Customer.Borrowers.Add(borrower);
            }
            foreach(var item in accounts)
            {
                decimal balance = 0;
                decimal loan = 0;
                if(item.Customer.Borrowers != null)
                {
                    foreach (var borrower in item.Customer.Borrowers)

                    {
                        loan += borrower.LoanAmount;
                    }
                }
                
                foreach (var deposit in item.Customer.Depositors)
                {
                    balance += deposit.Balance;
                }
                Console.WriteLine($"{item.AccountID} {item.Customer.Name} {item.Customer.Email} " +
                    $" {item.Customer.Mobile} {item.Customer.Address} {balance} {loan}");
            }
        }
    }
    class Account
    {
        public int AccountID { get; set; }
        public DateTime OpeningDate { get; set; }
        public Customer Customer { get; set; }

    }

    class Customer
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Depositor> Depositors { get; set; }
        public List<Borrower> Borrowers { get; set;}
    }

    class Depositor
    {
        public DateTime DepositDate { get; set; }
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }
    }

    class Borrower
    {
        public int LoanNumber { get; set; }
        public decimal LoanAmount { get; set; }
        //public Customer Customer { get; set; }
    }
}

