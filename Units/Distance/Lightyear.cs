using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Lightyear: Distance
    {
        private double conversionFactor = 30.48;

        public Lightyear(double amount = 0.0)
            : base(amount, (9.461e+17))
        {
        }
    }
}
