﻿using Autofac.Features.Metadata;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.AdapterDI
{
    public class AdapterDIMain
    {
        public static void Main_(string[] args)
        {
            // for each ICommand, a ToolbarButton is created to wrap it, and all
            // are passed to the editor
            var b = new ContainerBuilder();
            b.RegisterType<OpenCommand>()
              .As<ICommand>()
              .WithMetadata("Name", "Open");
            b.RegisterType<SaveCommand>()
              .As<ICommand>()
              .WithMetadata("Name", "Save");
            //b.RegisterType<Button>();
            b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd, ""));
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
              new Button(cmd.Value, (string)cmd.Metadata["Name"]));
            b.RegisterType<Editor>();
            using (var c = b.Build())
            {
                var editor = c.Resolve<Editor>();
                editor.ClickAll();

                // problem: only one button

                foreach (var btn in editor.Buttons)
                    btn.PrintMe();


            }
        }

    }
}
