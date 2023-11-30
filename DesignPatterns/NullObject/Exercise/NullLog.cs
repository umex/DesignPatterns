using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.Exercise
{
    public class NullLog : ILog
    {
        public int RecordLimit { get; } = int.MaxValue;
        public int RecordCount { get; set; } = int.MinValue;
        public void LogInfo(string message)
        {
            ++RecordCount;
        }
    }
}
