using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2.Clasess
{
    public abstract class Account
    {
        public string Costumer { get; set; }
        public enum CostumerType { Person, Company }
        public CostumerType TipClient { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public double NrOfMonths { get; set; }

        public Account(string costumer, CostumerType tipClient, double balance, double interestRate, double nrOfMonths)
        {
            this.Costumer = costumer;
            this.TipClient = tipClient;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.NrOfMonths = nrOfMonths;
        }
        public double DepositMoney(double CashAmount)
        {
            return Balance + CashAmount;
        }
        public virtual double InterestAmount()
        {
           return InterestRate * NrOfMonths * Balance; // dobanda se calculeaza aplicand rata dobanzii la balance, nu doar calculand rata dobanzii pe o anumita perioada
        }




    }
}
