using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.DetectingDecoratorCycles
{
    public class DetectingDecoratorCyclesMain
    {
        public static void Main(string[] args)
        {
            var circle = new Circle(2);
            var colored1 = new ColoredShape(circle, "red");
            var colored2 = new ColoredShape(colored1, "blue");

            Console.WriteLine(circle.AsString());
            Console.WriteLine(colored1.AsString());
            Console.WriteLine(colored2.AsString());


        }

    }
}
