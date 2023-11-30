using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.CompositeProxy_SoA_AoS
{
    public class SoACompositeProxyMain
    {
        public static void Main()
        {
            var creatures = new Creature[100];
            foreach (var c in creatures)
            {
                c.X++; // not memory-efficient
            }

            var creatures2 = new Creatures(100);
            foreach (var c in creatures2)
            {
                c.X++;
            }
        }

    }
}
