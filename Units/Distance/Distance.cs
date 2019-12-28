using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Distance : Unit
    {
        public double ConversionFactor { get; set; }
        public Distance(double amount = 0.0, double conversionFactor = 0.0)
            : base(amount)
        {
            ConversionFactor = conversionFactor;
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * ConversionFactor;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / ConversionFactor;
            return convertValue;
        }
    }
}
