using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Yard: Distance
    {
        public Yard(double amount = 0.0)
            : base(amount, 91.44)
        {
        }
    }
}
