using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.TemplateMethod
{
    public class TemplateMethodMain
    {
        static void Main()
        {
            var chess = new Chess();
            chess.Run();
        }

    }
}
