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
    class Ton : Mass
    {
        private double conversionFactor = 2000;
        public Ton(double amount = 0.0) 
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * conversionFactor;
            return new Pound(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / conversionFactor;
            return convertValue;
        }
    }
}
