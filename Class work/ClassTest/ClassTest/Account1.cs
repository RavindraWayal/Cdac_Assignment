using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Account1
    {
        static int get_id;
        int id;
        String First_name;
        String Last_name;
        double balance;
        
        static double interest_Rate=0.07;

        static Account1()
        {
            Console.WriteLine("Welcome to RBI");
        }

        public Account1():this("","",0)
        {

        }
        public Account1(String name):this(name,"",0)
        {
            this.First_name = name;
        }
        public Account1(string first_name, string last_name,int balance)
            
        {
            if (get_id < 2)
            {
                this.id = ++get_id;
            }
            else
            {
                throw new Exception("Account Creation limit is full..!!");
            }
            if(first_name.Length >3 && first_name.Length<12)
            {
                this.First_name = first_name;

            }
            else
            {
                
                throw new Exception("invalid name");
            }
       
            this.Last_name = last_name;
            if(balance > 1000) 
            {
                this.balance = balance;
                Console.WriteLine("your account is created successfully..!!"+ "\n"+ DateTime.Now );
            }
            else
            {
                throw new Exception("insufficent balance to create account");
            }
            
            
            
        }

        public void deposite(double amount)
        {
            if(amount > 500) 
            {
                balance += amount;
                Console.WriteLine("your amount deposited successfully..!!\n"+ DateTime.Now );
            }
            else
            {
                throw new Exception("insufficent amount to be deposited");
            }

        }
        public void withdraw(double amount)
        {
            const int min_bal = 1000;
            if((balance-amount) >min_bal )
            {
                balance -= amount;
                Console.WriteLine("your amount withdraw successfully..!!\n" + DateTime.Now);
            }
            else
            {
                throw new Exception("Your have to maintain the min_balance is 1000");
            }
        }
        public static double payint(Account1 obj)
        {
            double income = obj.balance+(obj.balance * 0.07);
            return income;

        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public String display()
        {
            return String.Format("Account holder name={0} balance={1} ", First_name, balance);
        }
        
    }
}
