using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed_Methods_And_Sealed_Classes
{
    public class LoanCustomer : BankCustomer
    {
        protected double LoanAmount { get; set; }

        /*  public override void GetDetails()
          {
           this can method canot  override becouse in the class base  is sealed
          }     */ 



    }
}
