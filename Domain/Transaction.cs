using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardCompany
{
    class Transaction
    {
        private DateTime Date { get; set; }
        private decimal Sum { get; set; }
        private int RecievingAccount { get; set; }
        private Account Account { get; set; }
    

        public Transaction(DateTime date, decimal sum, int recievingAccount, Account account)
        {
            Date = date;
            Sum = sum;
            RecievingAccount = recievingAccount;
            Account = account;
        }
        public void Pay()
        {

        }
    }
}
