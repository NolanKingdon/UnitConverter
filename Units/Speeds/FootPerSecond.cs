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
    class FootPerSecond : Speed
    {
        public FootPerSecond(double amount = 0.0) 
            : base(amount, 3.281)
        {
        }
    }
}
