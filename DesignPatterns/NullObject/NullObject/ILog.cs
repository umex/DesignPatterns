﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObject.NullObject
{
    public interface ILog
    {
        void Info(string msg);
        void Warn(string msg);
    }

}
