using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObjectSingleton
{
    public class NullObjectSingletonMain
    {
        static void Main()
        {
            ILog log = ILog.Null;
        }

    }
}
