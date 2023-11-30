using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObject
{
    public sealed class NullLog : ILog
    {
        public void Info(string msg)
        {

        }

        public void Warn(string msg)
        {

        }
    }

}
