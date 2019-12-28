using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Inch: Distance
    {
        public Inch(double amount = 0.0)
            : base(amount, 2.54)
        {
        }
    }
}
