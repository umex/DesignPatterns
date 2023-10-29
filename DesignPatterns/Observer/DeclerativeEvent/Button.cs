using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.DeclerativeEvent
{
    public class Button : ISend<ButtonPressedEvent>
    {
        public event EventHandler<ButtonPressedEvent> Sender;

        public void Fire(int clicks)
        {
            Sender?.Invoke(this, new ButtonPressedEvent
            {
                NumberOfClicks = clicks
            });
        }
    }

}
