using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    internal class CarWashService
    {
        private readonly ICarWashStrategy _carWashStrategy;

        public CarWashService(ICarWashStrategy carWashStrategy)
        {
            _carWashStrategy = carWashStrategy;
        }

        public void WashCar(Car car)
        {
            _carWashStrategy.CarWash(car);
        }
    }
}
