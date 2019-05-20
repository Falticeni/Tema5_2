using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Interfaces;

namespace Ex3.Clasess
{
    public class Order : IOrder
    {
        public int Number { get; set; }
        public IPerson Client { get; set; }
        public IVehicle Masina { get; set; }
        public IStore Magazin { get; set; }
        public int Timp { get; set; }

        public Order(IPerson client, IVehicle masina, IStore magazin, int timp)
        {
            Client = client;
            Masina = masina;
            Magazin = magazin;
            Timp = timp;
        }
    }
}
