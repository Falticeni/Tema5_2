using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Interfaces;

namespace Ex3.Clasess
{
    public class Customer : IPerson
    {
        public string FirstName { get; set; }
        public List<IOrder> Comenzi { get; set; } = new List<IOrder>();
        public Customer(string firstname)
        {
            this.FirstName = firstname;
        }
        public void Comanda(IVehicle masina, IStore magazin)
        {
            magazin.Comanda(masina, this);          // keyword-ul this se refera la obiectul curent (customer)
        }
        public void AnuleazaComanda(IStore magazin, IOrder comanda)
        {
            if (Comenzi.Exists(c => c.Magazin == comanda.Magazin && c.Number == comanda.Number))
            {
                magazin.AnuleazaComanda(comanda, this);
            }
        }

    }
}
