using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.DynamicProxyForLogging
{
    public class DynamicProxyForLoggingMain
    {
        static void Main()
        {
            //var ba = new BankAccount();
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            Console.WriteLine(ba);
        }

    }
}
