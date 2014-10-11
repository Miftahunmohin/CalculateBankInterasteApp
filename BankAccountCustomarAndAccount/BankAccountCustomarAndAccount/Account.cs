using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCustomarAndAccount
{
    class Account
    {
        public string number { set; get; }
        public string openingDate { set;get; }
        public double balance { private set; get; }

        public void deposite(double amount)
        {
            balance += amount;

        }

        public void withdraw(double amount)
        {
            balance -= amount;

        }

    }
}
