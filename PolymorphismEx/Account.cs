using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismEx
{
    class Account
    {
        public void account()
        {
            Console.WriteLine("account is created");
        }
        public void accName()
        {
            Console.WriteLine("account name is SBI Branch");
        }
        public virtual void AccountName()
        {
            Console.WriteLine("this is virtual method of account");
        }
    }
    class Customer : Account
    {
        public void customer()
        {       
            Console.WriteLine("customer account is created");
        }
        public override void AccountName()
        {
            Console.WriteLine("account is overridden the customer");
        }
    }
}
