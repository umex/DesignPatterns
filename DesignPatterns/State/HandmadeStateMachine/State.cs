using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.HandmadeStateMachine
{
    public enum State
    {
        OffHook,
        Connecting,
        Connected,
        OnHold
    }

}
