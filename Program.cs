using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Units.Currency;

namespace UnitConverter
{
    class Program
    {
        // TODO -> Add in help function
        static void Main(string[] args)
        {
            /**
             * Compatible currencies. Valid with API. Used to determine if we
             * fire off the currency code blocks
             */
            String[] currencies = { "aud", "bgn", "brl", "cad",
                                    "chf", "cny", "czk", "dkk",
                                    "gbp", "hkd", "hrk", "huf",
                                    "idr", "ils", "inr", "isk",
                                    "jpy", "krw", "mxn", "myr",
                                    "nok", "nzd", "php", "pln",
                                    "ron", "rub", "sek", "sgd",
                                    "thb", "try", "usd", "zar"};

            // Testing start
            Console.WriteLine("First unit");
            string first = Console.ReadLine();
            Console.WriteLine("Second unit");
            string second = Console.ReadLine();
            Console.WriteLine("Amount");
            string third = Console.ReadLine();
            double dt = double.Parse(third);
            // Testing end -> will be replaced with args

            /**
             * Currency consumes from an API and it's structure
             * is fundamentally different. Therefore it needs
             * it's own check
             * 
             * TODO -> Better catching of the currency types
             */
            if (currencies.Any(first.ToLower().Contains) && currencies.Any(second.ToLower().Contains))
            {
                try
                {
                    Console.WriteLine("Currency detected");
                    // Catching our Currency object
                    Currency currencyUnit = (Currency)Unit.Create("currency");
                    // Adding in the provided arguments in caps -> API doesn't accept lowercase
                    currencyUnit.CurrencyOne = first.ToUpper();
                    currencyUnit.CurrencyTwo = second.ToUpper();
                    currencyUnit.Amount = dt;
                    // Sending our request
                    currencyUnit.SendAPIRequest();
                    Console.WriteLine($"{Math.Round(currencyUnit.ConvertedAmount, 2)} {second.ToUpper()}");

                } catch (WebException e)
                {
                    Console.WriteLine($"{e.Message}");
                } catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                Console.ReadKey();
            } else
            {
                // Attempting Conversion
                try
                {
                    Unit originalUnit = Unit.Create(first);
                    Unit outputUnit = Unit.Create(second);
                    // Setting 20KM to be converted to M
                    originalUnit.Amount = dt;

                    // Setting a baseUnit (in this case CM)
                    var baseUnit = originalUnit.GetBase();

                    // Ensuring that our baseUnit implements baseable
                    if(baseUnit is IBaseable)
                    {
                        // treating our baseUnit as baseable
                        var baseableUnit = baseUnit as IBaseable;
                        // Assigning our output unit
                        outputUnit = baseableUnit.ConvertTo(outputUnit);
                    }
                    Console.WriteLine($"{originalUnit.Amount}{first}");
                    Console.WriteLine($"({baseUnit.Amount} in base)");
                    Console.WriteLine($"{outputUnit.Amount}{second}");

                } catch (ArgumentException e) // Thrown if no unit exists with the name provided
                {
                    // Invalid Argument Provided: {unit}
                    Console.WriteLine(e.Message);
                } catch (Exception e)
                {
                    Console.WriteLine($"Generic Error has occured: {e.Message}");
                }
                Console.ReadKey();
            }

        }
    }
}
