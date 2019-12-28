using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Mile: Distance
    {
        public Mile(double amount = 0.0)
            : base(amount, 160934)
        {
        }
    }
}
