using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Encapsulation
{
    public class Account
    {
        /*wrapping or binding of data
         * 
         * Advantages
         1.data hiding
        2. increased flexibility
        3.Reusability
         */
        private int accountBalance = 2000;

        //public void SetBalance(int amount)
        //{
        //    accountBalance = amount;
        //}
        //public void GetBalance()
        //{
        //    Console.WriteLine("Your account balance "+accountBalance);
        //}

        public int AccountBalance
        {
            set { accountBalance = value; }
            get { return accountBalance; }
        }
    }
}
