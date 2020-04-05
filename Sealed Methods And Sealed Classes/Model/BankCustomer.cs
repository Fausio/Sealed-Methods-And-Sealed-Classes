using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed_Methods_And_Sealed_Classes
{
    public class BankCustomer : Customer
    {
        #region Propertys
        protected int AcountNumber { get; set; }
        protected double Balance { get; set; }
        #endregion




        public override sealed void GetDetails()
        {
             base.GetDetails();
            Console.WriteLine("AcountNumber: ", AcountNumber);
            Console.WriteLine("Balance: ", Balance);
        }

    }
}
