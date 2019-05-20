using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }
        List<IOrder> Comenzi { get; set; }
        void Comanda(IVehicle masina, IStore magazin);
        void AnuleazaComanda(IStore magazin, IOrder comanda);
    }
}
