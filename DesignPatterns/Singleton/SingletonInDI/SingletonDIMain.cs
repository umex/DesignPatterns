using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton.SingletonInDI
{
    // socially acceptable 
    internal class SingletonDIMain
    {
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventBroker>().SingleInstance();
            builder.RegisterType<Foo>();

            using (var c = builder.Build())
            {
                var foo1 = c.Resolve<Foo>();
                var foo2 = c.Resolve<Foo>();

                Console.WriteLine(ReferenceEquals(foo1, foo2));
                Console.WriteLine(ReferenceEquals(foo1.Broker, foo2.Broker));
            }

        }
    }
}
