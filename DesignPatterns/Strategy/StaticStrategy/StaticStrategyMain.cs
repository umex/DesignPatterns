using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.StaticStrategy
{
    public class StaticStrategyMain
    {
        static void Main()
        {
            var tp = new TextProcessor<MarkdownListStrategy>();
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);

            var tp2 = new TextProcessor<HtmlListStrategy>();
            tp2.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp2);
        }

    }
}
