using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObject
{
    public class NullObjectMain
    {
        static void Main()
        {
            //var log = new ConsoleLog();
            //ILog log = null;
            //var log = new NullLog();
            var log = Null<ILog>.Instance;
            var ba = new BankAccount(log);
            ba.Deposit(100);
            ba.Withdraw(200);
        }
    }
}
