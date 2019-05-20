using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.Interfaces;

namespace Ex3.Interfaces
{
    public interface IVehicle : IProducer
    {
        string Model { get; set; }
        int Year { get; set; }
        double Price { get; set; }
    }
}
