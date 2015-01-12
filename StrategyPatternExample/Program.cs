using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate A Car and pass it through the Carwash.
            Car car = new Car("BMW");

            DeluxeWash WashProgramStrategy = new DeluxeWash();
            CarWashService carwash = new CarWashService(WashProgramStrategy);
            carwash.WashCar(car);
            Console.ReadLine();

            Car car2 = new Car("Skoda");

            BasicWash basic = new BasicWash();
            basic.CarWash(car2);
            Console.ReadLine();
        }
    }
}
