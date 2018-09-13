using System;


namespace CreditCardCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount to withdraw: ");
            decimal sum1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input date of transaction: [YYYY,MM,DD]");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Customer ArneNilsson = new Customer("Arne", "Nilsson", "020230-3057");
            Account ArnesAccount = new Account(123456789, 123.23, ArneNilsson);
            CreditCard ArnesCreditCard = new CreditCard(10000, 987654321, 456, ArnesAccount, ArneNilsson);
            Transaction SchweinteuerJacket = new Transaction(date1, sum1, 654654654, ArnesAccount);
            Transaction.Pay(sum1, date1);
        }
        
        
        
    }
}
