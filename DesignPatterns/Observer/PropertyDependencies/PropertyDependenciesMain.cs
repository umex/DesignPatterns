using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PropertyDependencies
{
    public class PropertyDependenciesMain
    {
        public static void Main(string[] args)
        {
            var p = new Person();
            p.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine($"{eventArgs.PropertyName} has changed");
            };
            p.Age = 15; // should not really affect CanVote :)
            p.Citizen = true;
        }

    }
}
