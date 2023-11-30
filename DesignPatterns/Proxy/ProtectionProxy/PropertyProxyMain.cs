using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.ProtectionProxy
{
    public class PropertyProxyMain
    {
        static void Main()
        {
            ICar car = new CarProxy(new Driver(12)); // 22
            car.Drive();
        }

    }
}
