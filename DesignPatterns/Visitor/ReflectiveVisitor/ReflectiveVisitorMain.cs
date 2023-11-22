using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.ReflectiveVisitor
{
    public class ReflectiveVisitorMain
    {
        public static void Main()
        {
            var e = new AdditionExpression(
              left: new DoubleExpression(1),
              right: new AdditionExpression(
                left: new DoubleExpression(2),
                right: new DoubleExpression(3)));
            var sb = new StringBuilder();
            ExpressionPrinter.Print2(e, sb);
            Console.WriteLine(sb);
        }

    }
}
