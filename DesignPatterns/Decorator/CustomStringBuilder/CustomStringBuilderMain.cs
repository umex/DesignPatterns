using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.CustomStringBuilder
{
    public class CustomStringBuilderMain
    {
        public static void Main(string[] args)
        {
            var cb = new CodeBuilder();
            cb.AppendLine("class Foo")
              .AppendLine("{")
              .AppendLine("}");
            Console.WriteLine(cb);
        }
    }
}
