﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Mass
{
    /// <summary>
    ///  Metric Tonne
    /// </summary>
    class Tonne : Mass
    {
        public Tonne(double amount = 0.0) 
            : base(amount, 2204.62)
        {
        }
    }
}
