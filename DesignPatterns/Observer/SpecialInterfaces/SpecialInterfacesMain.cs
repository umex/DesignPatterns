using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.SpecialInterfaces
{
    public class SpecialInterfacesMain : IObserver<Event>
    {
        public static void Main()
        {
            new SpecialInterfacesMain();
        }

        public SpecialInterfacesMain()
        {
            var person = new Person();
            var sub = person.Subscribe(this);
            person.OfType<FallsIllEvent>().Subscribe(args => Console.WriteLine($"A doctor has been called to {args.Address}"));

            person.CatchACold();
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
                Console.WriteLine($"A doctor has been called to {args.Address}");
        }

        public void OnError(Exception error) { }
        public void OnCompleted() { }
    }
}
