using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Inch: Distance
    {

        public Inch(double amount = 0.0)
            : base(amount)
        {
           // Console.WriteLine($"KM constructor: {amount}");
        }

        public override Unit GetBase()
        {
            //    100,000 CM in a KM
            var baseAmount = base.Amount * 2.54;
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            // 100000 CM in a M
            double convertValue = inBase / 2.54;
            return convertValue;
        }
    }
}
