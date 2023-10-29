using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.EventBroker
{
    public class PlayerScoredEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }
    }

}
