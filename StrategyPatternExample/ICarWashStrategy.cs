using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    interface ICarWashStrategy
    {
        void CarWash(Car car);
    }
}
