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
    class Panda : Mass
    {
        public Panda(double amount = 0.0) 
            : base(amount, 236.99665)
        {
        }
    }
}
