﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
