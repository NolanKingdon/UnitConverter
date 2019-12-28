using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Kilometer: Distance
    {
        public Kilometer(double amount = 0.0)
            : base(amount, 100000)
        {
        }
    }
}
