using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Milimeter: Distance
    {
        public Milimeter(double amount = 0.0)
            : base(amount, 0.1)
        {
        }
    }
}
