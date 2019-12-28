using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Mass
{
    class Kilogram : Mass
    {
        public Kilogram(double amount = 0.0) 
            : base(amount, 2.20462)
        {
        }
    }
}
