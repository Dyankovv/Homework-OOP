using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{
    public class Account
    {
        private int userID;
        private double userBalance;
        public Account(int userid, double userbalance)
        {
            ID = userid;
            Balance = userbalance;
        }
        public int ID
        {
            get { return userID; }
            set
            {
                if (value > 0) userID = value;
                else throw new Exception("ID can't be negaitve or zero");
            }
        }
        public double Balance
        {
            get { return userBalance; }
            set
            {
                if (value >= 0) userBalance = value;
                else throw new Exception("Balance can't be negative");
            }
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                throw new Exception("Insufficient balance");
            }
            else Balance -= amount;
            
        }
        public override string ToString()
        {
            return ($"Account ID{ID}, Balance {Balance:F2} ");
        }

    }
}
