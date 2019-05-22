using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1801681087.AutoParks
{
    public class Logistics
    {
        private int maxcargo;

        public int MaxCargo
        {
            get { return maxcargo; }
            private set { maxcargo = value; }
        }

        public Logistics(int maxcargo)
            : base()
        {
            this.MaxCargo = maxcargo;
        }

    }
}
