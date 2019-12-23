using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Yard: Distance
    {

        public Yard(double amount = 0.0)
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            double baseAmount = base.Amount * 91.44;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 91.44;
            return convertValue;
        }
    }
}
