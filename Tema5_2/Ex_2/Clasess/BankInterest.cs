using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2.Clasess
{
    public static class BankInterest
    {
        public static void Print(List<DepositAccount> ListaConturi)
        {
            int countD = 1;
            foreach (DepositAccount cont in ListaConturi)
            {
                Console.WriteLine("Dobanda contului de economisire nr. {0} este {1}.", countD, cont.InterestAmount());
                countD++;
            }
            Console.WriteLine(" ");
        }
        public static void Print(List<LoanAccount> ListaConturi)
        {
            int countL = 1;
            foreach (LoanAccount cont in ListaConturi)
            {
                Console.WriteLine("Dobanda contului de imprumut nr. {0} este {1}.", countL, cont.InterestAmount());
                countL++;
            }
            Console.WriteLine(" ");
        }
        public static void Print(List<MortgageAccount> ListaConturi)
        {
            int countM = 1;
            foreach (MortgageAccount cont in ListaConturi)
            {
                Console.WriteLine("Dobanda contului de ipoteca nr. {0} este {1}.", countM, cont.InterestAmount());
                countM++;
            }
            Console.WriteLine(" ");
        }
    }
}

