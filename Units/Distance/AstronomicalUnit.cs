using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class AstronomicalUnit: Distance
    {
        public AstronomicalUnit(double amount = 0.0)
            : base(amount, (1.496e+13))
        {
        }
    }
}
