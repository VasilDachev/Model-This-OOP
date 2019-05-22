using Homework_1801681087.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1801681087.Vehicles
{
    public abstract class MotorVehicle : IVehicle
    {
        private int power;
        private int maxpassanger;
        private int maxcargo;

        public int Power
        {
            get { return power; }
            private set { power = value; }
        }
        
        public int MaxPassenger
        {
            get { return maxpassanger; }
            private set { maxpassanger = value; }
        }
        

        public int MaxCargo
        {
            get { return maxcargo; }
            private set { maxcargo = value; }
        }

        public MotorVehicle(int power, int maxpassanger, int maxcargo)
        {
            this.Power = power;
            this.MaxPassenger = maxpassanger;
            this.MaxCargo = maxcargo;
        }



    }
}
