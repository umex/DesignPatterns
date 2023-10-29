﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.WeakEventPattern
{
    public class Window2
    {
        public Window2(Button button)
        {
            //WeakEventManager<Button, EventArgs>.AddHandler(button, "Clicked", ButtonOnClicked);
        }

        private void ButtonOnClicked(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Button clicked (Window2 handler)");
        }

        ~Window2()
        {
            Console.WriteLine("Window2 finalized");
        }
    }

}
