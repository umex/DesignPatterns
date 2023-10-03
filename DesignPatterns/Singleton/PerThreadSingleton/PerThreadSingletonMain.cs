using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.PerThreadSingleton
{
    public class PerThreadSingletonMain
    {
        public static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"t1: " + PerThreadSingleton.Instance.Id);
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"t2: " + PerThreadSingleton.Instance.Id);
                Console.WriteLine($"t2 again: " + PerThreadSingleton.Instance.Id);
            });
            Task.WaitAll(t1, t2);
        }
    }
}
