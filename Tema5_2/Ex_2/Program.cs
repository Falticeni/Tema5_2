using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_2.Clasess;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args) // folosirea unei interfete nu isi are rostul atat timp cat am creat o clasa abstrcta "Account" avand o metoda abstracta
        {
            DepositAccount DA1 = new DepositAccount("Vladimirescu Tudor", Account.CostumerType.Person, 2000d, 0.01d, 10d);
            DepositAccount DA2 = new DepositAccount("Grigore Lia", Account.CostumerType.Person, 900d, 0.008d, 18d);
            DepositAccount DA3 = new DepositAccount("SC Carturesti SA", Account.CostumerType.Company, 800d, 0.04d, 15d);
            DepositAccount DA4 = new DepositAccount("SC Haiducu SRL", Account.CostumerType.Company, 84000d, 0.006d, 14d);
            DepositAccount DA5 = new DepositAccount("SC Hai Cu Ma-Ta SRL", Account.CostumerType.Company, 50000d, 0.007d, 30d);
            List<DepositAccount> ConturiDepozit = new List<DepositAccount> { DA1, DA2, DA3, DA4, DA5 };
            BankInterest.Print(ConturiDepozit);

            LoanAccount LA1 = new LoanAccount("Vlaicu Mircea", Account.CostumerType.Person, 2500d, 0.0075d, 11d);
            LoanAccount LA2 = new LoanAccount("Tudose Ivan", Account.CostumerType.Person, 5000d, 0.0091d, 2d);
            LoanAccount LA3 = new LoanAccount("SC Safe Consulting Alt SRL", Account.CostumerType.Company, 10000d, 0.0063d, 10d);
            LoanAccount LA4 = new LoanAccount("SC Scam SRL", Account.CostumerType.Company, 10000d, 0.009d, 14d);
            LoanAccount LA5 = new LoanAccount("SC Altruc SRL", Account.CostumerType.Company, 20000d, 0.0085d, 1d);
            List<LoanAccount> ConturiImprumut = new List<LoanAccount> { LA1, LA2, LA3, LA4, LA5 };
            BankInterest.Print(ConturiImprumut);

            MortgageAccount MA1 = new MortgageAccount("Ciocan Robert", Account.CostumerType.Person, 100000d, 0.007d, 60d);
            MortgageAccount MA2 = new MortgageAccount("Ionescu Ana", Account.CostumerType.Person, 40000d, 0.006d, 5d);
            MortgageAccount MA3 = new MortgageAccount("SC Tupac SRL", Account.CostumerType.Company, 150000d, 0.005d, 50d);
            MortgageAccount MA4 = new MortgageAccount("SC Malter SRL", Account.CostumerType.Company, 200000d, 0.004d, 120d);
            MortgageAccount MA5 = new MortgageAccount("SC Conix SRL", Account.CostumerType.Company, 120000d, 0.004d, 110d);
            List<MortgageAccount> ConturiIpoteca = new List<MortgageAccount> { MA1, MA2, MA3, MA4, MA5 };
            BankInterest.Print(ConturiIpoteca);

            Console.ReadKey();
        }
    }
}
