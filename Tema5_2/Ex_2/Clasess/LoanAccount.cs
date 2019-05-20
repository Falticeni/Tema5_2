using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2.Clasess
{
    public class LoanAccount : Account
    {
        public LoanAccount(string costumer, CostumerType tipClient, double balance, double interestRate, double nrOfMonths) : base(costumer, tipClient, balance, interestRate, nrOfMonths) { }
        public override double InterestAmount()
        {
            if (TipClient is CostumerType.Person)
            {
                if (NrOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return InterestRate * (NrOfMonths - 3) * Balance;
                }
            }
            else
            {
                if (NrOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return InterestRate * (NrOfMonths - 2) * Balance;
                }
            }
        }
    }
}
