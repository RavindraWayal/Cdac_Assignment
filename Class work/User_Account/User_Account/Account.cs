using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Account
{
    public class Account
    {
        static int get_id;
        int id;
        String name;
        double balance;
        static float ROI = 0.07f;
        const int min_bal = 1000;
        DateTime d;

        static Account()
        {
            Console.WriteLine("Wlcome to the BOI");
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length>3 && value.Length<15)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name is too short you entered min 3 and max 15 char");
                }
                
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                {
                    balance = value;

                }
                else
                {
                    throw new Exception("you account is not created...!!\n required balance at least" + min_bal);
                }
            }
        }
        public Account(String name, double balance)
        {
            if(get_id<2)
            {
                this.id = ++get_id;
            }
            else
            {
                throw new Exception("You are not create account our limit is full...!!");
            }
            Name = name;
            Balance = balance;
            d = DateTime.Now;

        }
        public void Deposite(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("The deposited amount is not accepted");
            }
            else
            {
                balance += amount;
                Console.WriteLine("amount deposite successfully...!!"+DateTime.Now);
            }
        }
        public void withdraw(double amount)
        {
            if ((balance - amount) < min_bal)
            {
                throw new Exception("The balance amount is low");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount withdraw successful...!!" + DateTime.Now);
            }
        }
        public static double calint(Account ob)
        {
            return ob.balance+(ob.balance * ROI);

        }
        public String display()
        {
            return String.Format("name={0} balance={1}", name, balance);
        }

    }
}
