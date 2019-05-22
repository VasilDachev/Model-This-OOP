using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1801681087.Contracts
{
    public interface IVehicle
    {
         int Power { get; }
         int MaxPassenger { get; }
         int MaxCargo { get; }
    }
}
