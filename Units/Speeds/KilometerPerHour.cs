using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Speeds
{
    /// <summary>
    ///  Ton (2000lbs)
    /// </summary>
    class KilometerPerHour : Speed
    {
        public KilometerPerHour(double amount = 0.0) 
            : base(amount, 3.6)
        {
        }
    }
}
