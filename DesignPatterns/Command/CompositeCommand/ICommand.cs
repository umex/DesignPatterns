﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.CompositeCommand
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }

}
