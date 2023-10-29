using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.WeakEventPattern
{
    public class WeakEventPatternMain
    {
        // an event subscription can lead to a memory
        // leak if you hold on to it past the object's
        // lifetime

        // weak events help with this

        public static void Main(string[] args)
        {
            var btn = new Button();
            var window = new Window2(btn);
            //var window = new Window(btn);
            var windowRef = new WeakReference(window);
            btn.Fire();

            Console.WriteLine("Setting window to null");
            window = null;

            FireGC();
            Console.WriteLine($"Is window alive after GC? {windowRef.IsAlive}");

            btn.Fire();

            Console.WriteLine("Setting button to null");
            btn = null;

            FireGC();
        }

        private static void FireGC()
        {
            Console.WriteLine("Starting GC");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            Console.WriteLine("GC is done!");
        }

    }
}
