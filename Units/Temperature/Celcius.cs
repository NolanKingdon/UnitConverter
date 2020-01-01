using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Temperature
{
    /// <summary>
    ///  Ton (2000lbs)
    /// </summary>
    class Celcius : Temperature
    {
        public Celcius(double amount = 0.0) 
            : base(amount, 273.15)
        {
        }
        public override Unit GetBase()
        {
            var baseAmount = base.Amount + ConversionFactor;
            return new Kelvin(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase - ConversionFactor;
            return convertValue;
        }
    }
}
