using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardCompany
{
    class Customer
    {
        private string FirstName { get; }
        private string LastName { get; }
        private string SocialSecurityNumber { get; }

        public Customer(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
