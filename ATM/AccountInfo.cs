using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class AccountInfo
    {
        public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CardNumber { get; set; }
            public double CardBalance { get; set; }

            public AccountInfo(string firstName, string lastName, string cardNumber, double cardBalance)
            {
                FirstName = firstName;
                LastName = lastName;
                CardNumber = cardNumber;
                CardBalance = cardBalance;
            }
    }
}
