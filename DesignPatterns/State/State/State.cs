using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.State
{
    public abstract class State
    {
        public virtual void On(Switch sw)
        {
            Console.WriteLine("Light is already on.");
        }

        public virtual void Off(Switch sw)
        {
            Console.WriteLine("Light is already off.");
        }
    }

}
