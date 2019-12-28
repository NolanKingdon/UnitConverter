using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Foot: Distance
    {
        private double conversionFactor = 30.48;

        public Foot(double amount = 0.0)
            : base(amount, 30.48)
        {
        }
    }
}
