using System;

namespace PolymorphismEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Customer();
            ac.account();
            ac.accName();
            
            ac.AccountName();
            
        }
    }
}
