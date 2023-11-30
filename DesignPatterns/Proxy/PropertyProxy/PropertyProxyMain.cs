using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.PropertyProxy
{
    public class PropertyProxyMain
    {
        static void Main()
        {
            var c = new Creature();
            c.Agility = 10; // c.set_Agility(10) xxxxxxxxxxxxx
                            // c.Agility = new Property<int>(10)
            c.Agility = 10;
        }

    }
}
