using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Temperature
{
    class Temperature : Unit
    {
        public double ConversionFactor { get; set; }
        public Temperature(double amount = 0.0, double conversionFactor = 0.0)
            : base(amount)
        {
            ConversionFactor = conversionFactor;
        }

    }
}
