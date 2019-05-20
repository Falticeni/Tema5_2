using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2.Clasess
{
    public class DepositAccount : Account
    {
        public DepositAccount(string costumer, CostumerType tipClient, double balance, double interestRate, double nrOfMonths) : base(costumer, tipClient, balance, interestRate, nrOfMonths) { }

        public double WithdrawMoney(double CashAmount)
        {
            return Balance - CashAmount;
        }
        public override double InterestAmount()
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return InterestRate * NrOfMonths * Balance;
            }
        }
    }
}
