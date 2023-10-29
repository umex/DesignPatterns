using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.State
{
    public class StateMain
    {
        public static void Main(string[] args)
        {
            var ls = new Switch();

            ls.On();
            ls.Off();
        }

    }
}
