using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Units.Distance;
using UnitConverter.Units.Mass;
using UnitConverter.Units.Speeds;
using UnitConverter.Units.Currency;
using UnitConverter.Units.Temperature;

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
                #region distance
                // Distance Cases
                case "km":
                case "kilometer":
                    newUnit = new Kilometer();
                    break;
                case "m":
                case "meter":
                    newUnit = new Meter();
                    break;
                case "cm": // Base for distance
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
                case "au":
                case "astronomicalUnit":
                    newUnit = new AstronomicalUnit();
                    break;
                case "ly":
                case "lightyear":
                case "lightyears":
                    newUnit = new Lightyear();
                    break;
                #endregion
                #region mass
                // Mass Cases
                case "kgs":
                case "kilogram":
                    newUnit = new Kilogram();
                    break;
                case "lbs": // base for mass
                case "pound":
                    newUnit = new Pound();
                    break;
                case "tn":
                case "ton": // lbs
                    newUnit = new Ton();
                    break;
                case "tne":
                case "tonne": // Metric
                    newUnit = new Tonne();
                    break;
                case "corgs":
                case "corgis":
                case "ruby":
                case "rubes":
                    newUnit = new Corgi();
                    break;
                case "panda":
                    newUnit = new Panda();
                    break;
                case "g":
                case "gram":
                    newUnit = new Gram();
                    break;
                case "ug":
                case "microgram":
                    newUnit = new Microgram();
                    break;
                case "mg":
                case "milligram":
                    newUnit = new Milligram();
                    break;
                case "st":
                case "stone":
                    newUnit = new Stone();
                    break;
                case "oz":
                case "ounce":
                    newUnit = new Ounce();
                    break;
                #endregion
                #region speed
                case "kmh":
                case "kilometers/h":
                    newUnit = new KilometerPerHour();
                    break;
                case "mps": // Base
                case "meters/s":
                    newUnit = new MeterPerSecond();
                    break;
                case "fps":
                case "foot/s":
                    newUnit = new FootPerSecond();
                    break;
                case "mph":
                case "miles/h":
                    newUnit = new MilesPerHour();
                    break;
                case "kn":
                case "knots":
                    newUnit = new Knot();
                    break;
                #endregion
                #region currency
                case "currency":
                    // TODO -> Fix this later
                    newUnit = new Currency();
                    break;
                #endregion
                #region temperature
                case "k":
                case "kelvin": // base
                    newUnit = new Kelvin();
                    break;
                case "c":
                case "celcius":
                    newUnit = new Celcius();
                    break;
                case "f":
                case "fahrenheight":
                    newUnit = new Fahrenheight();
                    break;
                #endregion
                default:
                    throw new ArgumentException($"Invalid Argument Provided: {unit}");
            }
            return newUnit;
        }
    }
}
