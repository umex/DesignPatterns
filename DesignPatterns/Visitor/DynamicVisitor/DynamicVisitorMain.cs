using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.DynamicVisitor
{
    public class DynamicVisitorMain
    {
        public static void Main()
        {
            var e = new AdditionExpression(
              left: new DoubleExpression(1),
              right: new AdditionExpression(
                left: new DoubleExpression(2),
                right: new DoubleExpression(3)));
            var ep = new ExpressionPrinter();
            var sb = new StringBuilder();
            ep.Print((dynamic)e, sb);
            Console.WriteLine(sb);

            // disadvantages:

            // 1) Performance penalty
            // 2) Runtime error on missing visitor
            // 3) Problematic w.r.t. inheritance
        }

    }
}
