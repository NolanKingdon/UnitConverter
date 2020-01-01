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
    class Fahrenheight : Temperature
    {
        public Fahrenheight(double amount = 0.0) 
            : base(amount, 459.67)
        {
        }
        
        public override Unit GetBase()
        {
            double baseAmount = (base.Amount + ConversionFactor) * 5/9;
            return new Kelvin(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = (inBase * 9/5) - ConversionFactor;
            return convertValue;
        }
    }
}
