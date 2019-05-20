using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Interfaces
{
    public interface IOrder
    {
        int Number { get; set; }
        IPerson Client { get; set; }
        IVehicle Masina { get; set; }
        IStore Magazin { get; set; }
        int Timp { get; set; }
    }
}
