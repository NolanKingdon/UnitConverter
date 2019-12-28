using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Mass
{
    /// <summary>
    ///  Ton (2000lbs)
    /// </summary>
    class Microgram : Mass
    {
        public Microgram(double amount = 0.0) 
            : base(amount, (4.536e+8))
        {
        }
    }
}
