using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Distance
{
    class Planck: Distance
    {

        public Planck(double amount = 0.0)
            : base(amount)
        {
           // Console.WriteLine($"KM constructor: {amount}");
        }

        public override Unit GetBase()
        {
            //    100,000 CM in a KM
            var baseAmount = base.Amount * (1.61605E-33);
            return new Centimeter(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            // 100000 CM in a M
            double convertValue = inBase / (1.61605E-33);
            return convertValue;
        }
    }
}
