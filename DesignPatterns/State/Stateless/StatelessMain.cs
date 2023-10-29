using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Stateless;

namespace DesignPatterns.State.Stateless
{
    public class StatelessMain
    {
        public static void Main()
        {
            var stateMachine = new StateMachine<Health, Activity>(Health.NonReproductive);
            stateMachine.Configure(Health.NonReproductive)
              .Permit(Activity.ReachPuberty, Health.Reproductive);
            stateMachine.Configure(Health.Reproductive)
              .Permit(Activity.Historectomy, Health.NonReproductive)
              .PermitIf(Activity.HaveUnprotectedSex, Health.Pregnant,
                () => ParentsNotWatching);
            stateMachine.Configure(Health.Pregnant)
              .Permit(Activity.GiveBirth, Health.Reproductive)
              .Permit(Activity.HaveAbortion, Health.Reproductive);
            
        }

        public static bool ParentsNotWatching
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

    }
}
