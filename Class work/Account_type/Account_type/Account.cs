using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_type
{
     class Account
    {
      public void method(string s)
        {
           Console.WriteLine(s);
        }
     }
    class person:Account
    {
        public void methos(double d)
        {
            Console.WriteLine(d);
        }
    }
}
