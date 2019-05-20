using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Interfaces
{
    public interface IStore
    {
        string Name { get; set; }
        string City { get; set; }
        int Timp { get; set; }
        List<IVehicle> Masini { get; set; }
        List<IOrder> Comenzi { get; set; }
        void Comanda(IVehicle masina, IPerson client);
        void AnuleazaComanda(IOrder comanda, IPerson client);
    }
}
