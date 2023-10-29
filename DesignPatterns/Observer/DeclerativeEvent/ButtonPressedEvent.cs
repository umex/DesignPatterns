using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.DeclerativeEvent
{
    public class ButtonPressedEvent : IEvent
    {
        public int NumberOfClicks;
    }

}
