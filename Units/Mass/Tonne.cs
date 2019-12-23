using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Mass
{
    /// <summary>
    ///  Metric Tonne
    /// </summary>
    class Tonne : Mass
    {
        public Tonne(double amount = 0.0) 
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * 2204.62;
            return new Pound(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 2204.62;
            return convertValue;
        }
    }
}
