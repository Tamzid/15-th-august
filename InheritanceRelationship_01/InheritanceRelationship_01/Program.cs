using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InheritanceRelationship_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount1 = new SavingsAccount("sv-001", "Sami", 4500);            
            CheckingAccount checkingAccount1 = new CheckingAccount("chk-001", "Rana", 6500);
            SavingsAccount savingsAccount2 = new SavingsAccount("sv-002", "Alif", 3000);
            RegularAccount regularAccount1 = new RegularAccount("Reg-001", "Polok");
            regularAccount1.Deposit(12000);
            regularAccount1.Withdraw(4000);


            savingsAccount1.Deposit(3000);
            savingsAccount1.Withdraw(1000);
            savingsAccount2.Deposit(7000);
            savingsAccount2.Withdraw(2000);
            checkingAccount1.Deposit(4500);
            checkingAccount1.Withdraw(5000);

            List<Account> accounts = new List<Account>();
            accounts.Add(savingsAccount1);
            accounts.Add(savingsAccount2);
            accounts.Add(checkingAccount1);
            accounts.Add(regularAccount1);
            
            ShowAccountsInformation(accounts);
            Console.ReadKey();
        }

        private static void ShowAccountsInformation(List<Account> accounts)
        {
            foreach (Account anAccount in accounts)
            {
                Console.WriteLine(anAccount.GetInfo());
            }
        }

    }
}
