using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Kilometer: Distance
    {

        public Kilometer(double amount = 0.0)
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * 100000;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 100000;
            return convertValue;
        }
    }
}
