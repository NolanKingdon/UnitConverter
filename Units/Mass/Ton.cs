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
        public Ton(double amount = 0.0) 
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            var baseAmount = base.Amount * 2000;
            return new Pound(baseAmount);
        }

        public override double GetConvertValue(double inBase)
        {
            double convertValue = inBase / 2000;
            return convertValue;
        }
    }
}
