using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units.Temperature
{
    class Kelvin : Temperature, IBaseable
    {
        public Kelvin(double amount = 0.0) 
            : base(amount)
        {
        }

        public override Unit GetBase()
        {
            // We are in the base class, so it will return itself
            return this;
        }

        public override double GetConvertValue(double inBase)
        {
            // This is the base value from earlier in the flow -> Just bouncing it back
            return inBase;
        }

        public Unit ConvertTo(Unit targetUnit)
        {
            if(targetUnit is Temperature)
            {
                double convertValue = targetUnit.GetConvertValue(base.Amount);
                targetUnit.Amount = convertValue;
            } else
            {
                throw new ArgumentException("Unit types do not match");
            }
            return targetUnit;
        }
    }
}
