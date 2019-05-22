using System;
using System.Collections.Generic;
using System.Text;
using Homework_1801681087.Vehicles;

namespace Homework_1801681087.AutoParks
{
    public abstract class AutoPark
    {
        private List<MotorVehicle> vehicles;

        public List<MotorVehicle> Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }
        public AutoPark()
        {
            vehicles = new List<MotorVehicle>();
        }
    }
}
