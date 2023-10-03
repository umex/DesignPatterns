using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.ObjectTrackingAndBulkReplacement
{
    public class ObjectTrackingAndBulkReplacementMain
    {
        public static void Main()
        {
            var factory = new TrackingThemeFactory();
            var theme = factory.CreateTheme(true);
            var theme2 = factory.CreateTheme(false);
            Console.WriteLine(factory.Info);
            // Dark theme
            // Light theme


            // replacement
            var factory2 = new ReplaceableThemeFactory();
            var magicTheme = factory2.CreateTheme(true);
            Console.WriteLine(magicTheme.Value.BgrColor); // dark gray
            factory2.ReplaceTheme(false);
            Console.WriteLine(magicTheme.Value.BgrColor); // white
        }
    }
}
