using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.DynamicStrategy
{
    public class DynamicStrategyMain
    {
        static void Main()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);
        }

    }
}
