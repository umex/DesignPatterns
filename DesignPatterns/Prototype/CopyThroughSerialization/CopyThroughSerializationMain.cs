using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.CopyThroughSerialization
{
    public class CopyThroughSerializationMain
    {
        public static void Main()
        {
            Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            Foo foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            Console.WriteLine(foo);
            Console.WriteLine(foo2);
        }
    }
}
