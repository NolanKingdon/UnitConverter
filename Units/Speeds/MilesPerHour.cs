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
    class MilesPerHour : Speed
    {
        public MilesPerHour(double amount = 0.0) 
            : base(amount, 2.237)
        {
        }
    }
}
