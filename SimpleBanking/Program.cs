using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SimpleBanking
{
    internal class Program
    {
        static int noOfAccount;
        static List<Account> accounts= new List<Account>();

        static void Main(string[] args)
        {
            Console.WriteLine("How many account you want to open?");
            noOfAccount= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= noOfAccount; i++)
            {
                Account account = new Account()
                {
                    AccountId = (555 + i).ToString(),
                    OpeningDate = DateTime.Now,
                };

                Customer customer = new Customer();
                Console.Write($"Customer name:_ ");
                customer.Name = Console.ReadLine();
                account.Customer = customer;

                Console.WriteLine("How many amount you want to deposit");
                List<Depositor> depositors= new List<Depositor>();
                depositors.Add(new Depositor()
                {
                    DepositDate = DateTime.Now,
                    Balance = Convert.ToDecimal(Console.ReadLine()),
                });

                customer.Depositors= depositors;
                accounts.Add(account);
            }


            Console.WriteLine("\n\n");
            Console.WriteLine($"Account \t Customer \t Balance");

            foreach (var item in accounts)
            {
                decimal balance = 0;
                foreach(var deposit in item.Customer.Depositors)
                {
                    balance += deposit.Balance;
                }
                Console.WriteLine($"{item.AccountId}  {item.Customer.Name}  " +
                    $"{item.Customer.Email} {item.Customer.Mobile} {balance}");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");

            Console.WriteLine("Who want to deposit?");
            string accountNo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Deposit Amount?");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());


            var accountInSearch = accounts.Where(a => a.AccountId== accountNo).FirstOrDefault();
            
            if(accountInSearch != null)
            {
                Depositor depositor = new Depositor()
                {
                    DepositDate = DateTime.Now,
                    Balance = depositAmount
                };

                accountInSearch.Customer.Depositors.Add(depositor);
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
                Console.WriteLine($"{item.AccountId}  {item.Customer.Name}  " +
                    $"{item.Customer.Email} {item.Customer.Mobile} {balance}");
            }

        }

    }
}
