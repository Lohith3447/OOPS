using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountOops
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount (string owner, decimal interestRate): base (owner + "("  + interestRate + "%)")
        {
            InterestRate  = interestRate;
        }
    }
}
