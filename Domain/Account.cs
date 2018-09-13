using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardCompany
{
    class Account
    {
        private int AccountNumber { get; set; }
        private double Balance { get; set; }
        private Customer Customer { get; set; }

        public Account(int accountNumber, double balance, Customer customer)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Customer = customer;
        }
    }
}
