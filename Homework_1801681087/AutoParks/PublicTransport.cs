using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1801681087.AutoParks
{
    public class PublicTransport:AutoPark
    {
        private int maxpassangers;

        public int MaxPassangers
        {
            get { return maxpassangers; }
            private set { maxpassangers = value; }
        }
        public PublicTransport(int maxpassangers)
            : base ()
        {
            this.MaxPassangers = maxpassangers;

        }


    }
}
