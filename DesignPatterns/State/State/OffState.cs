using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.State
{
    public class OffState : State
    {
        public OffState()
        {
            Console.WriteLine("Light turned off.");
        }

        public override void On(Switch sw)
        {
            Console.WriteLine("Turning light on...");
            sw.State = new OnState();
        }
    }

}
