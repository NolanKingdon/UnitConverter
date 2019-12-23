﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Units.Distance;

namespace UnitConverter
{
    class Unit
    {
        public double Amount { get; set; }
        public Unit(double amount)
        {
           // Console.WriteLine($"Unit constructor: {amount}");
            this.Amount = amount;
        }

        /// <summary>
        ///  Template for lower classes -> To be overridden in the base class
        ///  but included here to be accessible without casting
        /// </summary>
        /// <returns>null</returns>
        public virtual Unit GetBase()
        {
            return null;
        }

        /// <summary>
        ///  Template for lower classes -> To be overridden in the base class
        ///  but included here to be accessible without casting
        /// </summary>
        /// <returns>null</returns>
        public virtual Double GetConvertValue(double inBase)
        {
            return 0.0;
        }

        /// <summary>
        /// Where the units are created
        /// 
        /// All new units must go in here
        /// </summary>
        /// <returns>Unit type -> Centimeter, Meter, Mile, etc.</returns>
        public static Unit Create(string unit)
        {
            Unit newUnit;
            switch (unit.ToLower())
            {
                // Distance Cases
                case "km":
                case "kilometer":
                    newUnit = new Kilometer();
                    break;
                case "m":
                case "meter":
                    newUnit = new Meter();
                    break;
                case "cm":
                case "centimeter":
                    newUnit = new Centimeter();
                    break;
                case "mm":
                case "milimeter":
                    newUnit = new Milimeter();
                    break;
                case "mi":
                case "mile":
                    newUnit = new Mile();
                    break;
                case "yd":
                case "yard":
                    newUnit = new Yard();
                    break;
                case "ft":
                case "foot":
                    newUnit = new Foot();
                    break;
                case "in":
                case "inch":
                    newUnit = new Inch();
                    break;
                case "pl":
                case "planck":
                    newUnit = new Planck();
                    break;
                // Mass Cases
                default:
                    newUnit = null;
                    break;
            }
            return newUnit;
        }
    }
}