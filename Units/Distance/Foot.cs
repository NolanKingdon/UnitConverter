using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Foot: Distance
    {

        public Foot(double amount = 0.0)
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * 30.48;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 30.48;
            return convertValue;
        }
    }
}
