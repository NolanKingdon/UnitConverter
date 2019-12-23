using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing start
            Console.WriteLine("First unit");
            string first = Console.ReadLine();
            Console.WriteLine("Second unit");
            string second = Console.ReadLine();
            Console.WriteLine("Amount");
            string third = Console.ReadLine();
            double dt = double.Parse(third);
            // Testing end -> will be replaced with args

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

            Console.ReadKey();
        }
    }
}
