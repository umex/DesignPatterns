using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReductionsAndTransforms
{
    internal class ReductionsAndTransformsMain
    {
        static void Main()
        {
            var expr = new AdditionExpression(
              new DoubleExpression(1), new DoubleExpression(2));
            var et = new EvaluationTransformer();
            var result = expr.Reduce(et);
            var pt = new PrintTransformer();
            var text = expr.Reduce(pt);
            Console.WriteLine($"{text} = {result}"); // (1 + 2) = 3

            var st = new SquareTransformer();
            var newExpr = expr.Reduce(st);
            text = newExpr.Reduce(pt);
            Console.WriteLine(text); // (1 + 4)
        }

    }
}
