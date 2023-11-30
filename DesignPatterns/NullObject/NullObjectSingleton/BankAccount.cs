using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObjectSingleton
{
    public class BankAccount
    {
        public BankAccount(ILog log = ILog.Null)
        {

        }
    }
}
