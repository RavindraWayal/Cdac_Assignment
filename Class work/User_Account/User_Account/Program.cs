using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account a1 = new Account("Akki", 200000);
                a1.Deposite(10000);
                a1.withdraw(100);
                Console.WriteLine(a1.display());
                double income = Account.calint(a1);

                Console.WriteLine("The final amount with ROI " + income);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Account a2 = new Account("jayesh", 10000);
                a2.Deposite(100);
                a2.withdraw(1000);
                Console.WriteLine(a2.display());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
