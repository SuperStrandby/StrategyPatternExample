using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class BasicWash : ICarWashStrategy
    {
        // Inherit from the ICarWashStrategy interface and make the CarWash method for BasicWash that implements the properties of BasicWash
        public void CarWash(Car car)
        {
            Console.WriteLine("** Basic Wash initiated on {0} **", car._name);
            Console.WriteLine("Water");
            Console.WriteLine("Soap");
            Console.WriteLine("Clean");
            Console.WriteLine("Dry");
            Console.WriteLine("** Done **");
        }
    }
    
}
