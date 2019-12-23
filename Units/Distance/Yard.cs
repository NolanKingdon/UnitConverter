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
           // Console.WriteLine($"M constructor: {amount}");
        }

        public override Unit GetBase()
        {
            //    100 CM in a M
            double baseAmount = base.Amount * 91.44;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            // 100 CM in a M
            double convertValue = inBase / 91.44;
            return convertValue;
        }
    }
}
