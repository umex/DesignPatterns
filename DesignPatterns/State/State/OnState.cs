using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.State
{
    public class OnState : State
    {
        public OnState()
        {
            Console.WriteLine("Light turned on.");
        }
        public override void Off(Switch sw)
        {
            Console.WriteLine("Turning light off...");
            sw.State = new OffState();
        }
    }

}
