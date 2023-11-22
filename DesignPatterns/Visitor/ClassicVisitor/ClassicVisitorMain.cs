using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ClassicVisitor
{
    public class ClassicVisitorMain
    {
        public static void Main()
        {
            var e = new AdditionExpression(
              left: new DoubleExpression(1),
              right: new AdditionExpression(
                left: new DoubleExpression(2),
                right: new DoubleExpression(3)));
            var ep = new ExpressionPrinter();
            ep.Visit(e);
            Console.WriteLine(ep.ToString());

            var calc = new ExpressionCalculator();
            calc.Visit(e);
            Console.WriteLine($"{ep} = {calc.Result}");
        }

    }
}
