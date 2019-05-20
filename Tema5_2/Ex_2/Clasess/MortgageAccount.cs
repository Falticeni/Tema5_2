using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2.Clasess
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(string costumer, CostumerType tipClient, double balance, double interestRate, double nrOfMonths) : base(costumer, tipClient, balance, interestRate, nrOfMonths) { }
        public override double InterestAmount()
        {
            if (TipClient is CostumerType.Company)
            {
                if (NrOfMonths <= 12)
                {
                    return NrOfMonths * 0.5 * InterestRate * Balance;
                }
                else
                {
                    return Balance * (12 * 0.5 * InterestRate + InterestRate * (NrOfMonths - 12)); // dobanda acumulata in primele 12 luni + dobanda rezultata in lunile urmatoare
                }
            }
            else
            {
                if (NrOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return InterestRate * (NrOfMonths - 6) * Balance;
                }
            }
        }
    }
}

