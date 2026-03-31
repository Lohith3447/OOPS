using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountOops
{
    public class BankAccount
    {
        public string Owner {  get; set; }

        public Guid AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        public BankAccount(string owner) 
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0) return "You cannot deposit $" + amount;
            if (amount > 2000) return "Deposit limit reached";

            Balance += amount;

            return "Deposit completed successfully";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0) return "You cannot withdraw $" + amount;
            if (amount > Balance) return "You dont have enought money";

            Balance -= amount;

            return "Withdraw completed successfully";
        }

    }

}
