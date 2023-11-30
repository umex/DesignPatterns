using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObjectSingleton
{
    interface ILog
    {
        public void Warn();

        public static ILog Null => NullLog.Instance;

        private sealed class NullLog : ILog
        {
            private NullLog() { }

            private static Lazy<NullLog> instance =
              new Lazy<NullLog>(() => new NullLog());

            public static ILog Instance => instance.Value;

            public void Warn()
            {

            }
        }
    }

}
