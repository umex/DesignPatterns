using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.StepwiseBuilder
{
    public class StepwiseBuilderMain
    {
        public static void Main(string[] args)
        {
            var car = CarBuilder.Create() //ISpecifyCarType
              .OfType(CarType.Crossover)  //ISpecifyWheelSize
              .WithWheels(18)             //IBuildCar
                    .Build();
            Console.WriteLine(car);
        }
    }
}
