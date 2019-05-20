using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Clasess;
using Ex3.Interfaces;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args) // emailul primit de la Mihai
        {
            IPerson Client = new Customer("Alex");

            IVehicle FordFocus = new Car("Ford", "Focus", 2015);

            IStore FordStore = new Store("FordStore", "Bucuresti", 4,
                new List<IVehicle>() // construirea unui obiect nou folosit direct ca parametru
                {
                    new Car("Ford","Focus",2015, 15000)
                }
            );// nu se pot instanta obiecte din interfate ci doar din clase            

            IStore SkodaStore = new Store("SkodaStore", "Bucuresti", 3,
                new List<IVehicle>()
                {
                    new Car("Ford","Focus",2015, 14000)
                }
            );

            Client.Comanda(FordFocus, FordStore); // parametrii de tipul interfatei
            Console.WriteLine("Am comandat de la Ford.");
            Client.Comanda(FordFocus, SkodaStore);
            Console.WriteLine("Am comandat de la Skoda.");
            Client.AnuleazaComanda(FordStore, Client.Comenzi.Find(m => m.Masina.Model == FordFocus.Model));
            Console.WriteLine("Am anulat comanda de la Ford.");
            Console.ReadKey();
        }
    }
}
