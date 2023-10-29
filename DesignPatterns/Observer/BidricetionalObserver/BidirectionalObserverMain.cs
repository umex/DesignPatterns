using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.BidricetionalObserver
{
    public class BidirectionalObserverMain
    {
        public static void Main()
        {
            var product = new Product { Name = "Book" };
            var window = new Window(product);

            // want to ensure that when product name changes
            // in one component, it also changes in another

            // product.PropertyChanged += (sender, eventArgs) =>
            // {
            //   if (eventArgs.PropertyName == "Name")
            //   {
            //     Console.WriteLine("Name changed in Product");
            //     window.ProductName = product.Name;
            //   }
            // };
            //
            // window.PropertyChanged += (sender, eventArgs) =>
            // {
            //   if (eventArgs.PropertyName == "ProductName")
            //   {
            //     Console.WriteLine("Name changed in Window");
            //     product.Name = window.ProductName;
            //   }
            // };

            using var binding = new BidirectionalBinding(
              product,
              () => product.Name,
              window,
              () => window.ProductName);

            // there is no infinite loop because of
            // self-assignment guard
            product.Name = "Table";
            window.ProductName = "Chair";

            Console.WriteLine(product);
            Console.WriteLine(window);
        }

    }
}
