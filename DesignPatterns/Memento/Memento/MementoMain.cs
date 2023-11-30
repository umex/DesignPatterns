using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Memento
{
    public class MementoMain
    {
        static void Main()
        {
            var ba = new BankAccount(100);
            var m1 = ba.Deposit(50); // 150
            var m2 = ba.Deposit(25); // 175
            Console.WriteLine(ba);

            // restore to m1
            ba.Restore(m1);
            Console.WriteLine(ba);

            ba.Restore(m2);
            Console.WriteLine(ba);
        }

    }
}
