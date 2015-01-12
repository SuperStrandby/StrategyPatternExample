using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class DeluxeWash : ICarWashStrategy
    {
        // Inherit from the ICarWashStrategy interface and make the CarWash method for DeluxecWash that implements the properties of DeluxeWash
        public void CarWash(Car car)
        {
            Console.WriteLine("** Deluxe Wash initiated on {0} **", car._name);
            Console.WriteLine("Add lots of Water");
            Console.WriteLine("Spray plenty of Soap");
            Console.WriteLine("Tire Brush");
            Console.WriteLine("Wrap-Around Washers");
            Console.WriteLine("Rinse and Wax");
            Console.WriteLine("Soft Dry");
            Console.WriteLine("** Deluxe Wash Completed **");
        }
    }
}
