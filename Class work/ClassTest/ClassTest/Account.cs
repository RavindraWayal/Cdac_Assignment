using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Account
    {
        String name;
        int id;
        double balance;
        
        public Account(string name, int id, double balance) 
        {
            this.name = name;
            this.id = id;
            if (balance > 1000)
            {
                this.balance = balance;
                
            }
            else
            {
                throw new ArgumentException("The account create balance is not sufficent");
            }
            
           
        }
        public void deposite(int amount)
        {
            if(amount>=100)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException("The deposite amount is minimum 1000");
            }
        }

            public void withdraw(int amount)
        {
            if (balance > 500 && amount < 5000)
            {
                balance -= amount;
            }
            else
            {

                throw new ArgumentException("The withdraw amount is upto 5000");
            }
        }

        public String display()
        {
            return String.Format("name={0} id={1} balance={2}",name ,id,balance );
        }
    }
}
