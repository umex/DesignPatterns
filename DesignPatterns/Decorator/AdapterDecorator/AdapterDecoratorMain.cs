using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.AdapterDecorator
{
    public class AdapterDecoratorMain
    {
        public static void Main(string[] args)
        {
            MyStringBuilder s = "hello ";
            s += "world"; // will work even without op+ in MyStringBuilder
                          // why? you figure it out!
            Console.WriteLine(s);
        }

    }
}
