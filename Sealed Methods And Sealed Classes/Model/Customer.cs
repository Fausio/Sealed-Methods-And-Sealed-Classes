using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed_Methods_And_Sealed_Classes
{
    public class Customer
    {
        #region Propertys
        protected int CustomerId { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }
        #endregion

        public virtual void GetDetails()
        {
            Console.WriteLine("Customer Construtor");

            Console.WriteLine("CustomerId: ", CustomerId);
            Console.WriteLine("Name: ", Name);
            Console.WriteLine("Email: ", Email);
        }

    }
}
