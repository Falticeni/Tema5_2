using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Interfaces;


namespace Ex3.Clasess
{
    public class Store : IStore
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<IVehicle> Masini { get; set; }
        public List<IOrder> Comenzi { get; set; } = new List<IOrder>(); // am creat o lista de comenzi
        public int Timp { get; set; }

        private int lastNumber = 0;

        public Store(string name, string city, int timp, List<IVehicle> masini)
        {
            this.Name = name;
            this.City = city;
            this.Masini = masini;
            this.Timp = timp;
        }
        public void Comanda(IVehicle masina, IPerson client)
        {
            if (Masini.Exists(m => m.Manufacturer == masina.Manufacturer && m.Model == masina.Model))
            {
                IOrder comanda = new Order(client, masina, this, Timp);
                comanda.Number = ++lastNumber;
                comanda.Masina = Masini.Find(m => m.Manufacturer == masina.Manufacturer && m.Model == masina.Model);
                Comenzi.Add(comanda);
                client.Comenzi.Add(comanda);
            }
        }
        public void AnuleazaComanda(IOrder comanda, IPerson client)
        {
            if (Comenzi.Exists(c => c.Number == comanda.Number))
            {
                Comenzi.Remove(Comenzi.Find(c => c.Number == comanda.Number));
                client.Comenzi.Remove(client.Comenzi.Find(c => c.Magazin == comanda.Magazin && c.Number == comanda.Number));
            }
        }
    }
}
