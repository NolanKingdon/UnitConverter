using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Mass
{
    class Kilogram : Mass
    {
        public Kilogram(double amount = 0.0) 
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * 2.20462;
            return new Pound(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 2.20462;
            return convertValue;
        }
    }
}
