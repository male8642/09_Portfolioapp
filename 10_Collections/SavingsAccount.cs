using System;
using System.Collections;
using System.Collections.Generic;




namespace _10_Collections
{
    public class SavingsAccount 
    {


        public double InterestRate { get; set; }
        public string Account { get; set; }
        public double Value { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(string account, double value, double interestRate)
        {
            Account = account;
            Value = value;
            InterestRate = interestRate;
        }

        public double GetValue()
        {
            return Value;
        }

        public override string ToString()
        {

            {
                return "SavingsAccount[" + "value=" + Value + ".0," + "interestRate=" + InterestRate + "]";
            }
        }

        public void ApplyInterest()
        {
            Value += Value * (InterestRate / 100);
        }
    }
}
