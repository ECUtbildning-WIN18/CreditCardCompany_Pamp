using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardCompany
{
    class CreditCard
    {
        private int Limit { get; set; }
        private int CardNumber { get; }
        private int Csv { get; }
        private Account Account { get; }
        private Customer Customer { get; }

        public CreditCard(int limit, int cardNumber, int csv, Account account, Customer customer)
        {
            Limit = limit;
            CardNumber = cardNumber;
            Csv = csv;
            Account = account;
            Customer = customer;
        }
    }
}
