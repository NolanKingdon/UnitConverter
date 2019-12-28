using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Planck: Distance
    {
        public Planck(double amount = 0.0)
            : base(amount, (1.61605E-33))
        {
        }
    }
}
