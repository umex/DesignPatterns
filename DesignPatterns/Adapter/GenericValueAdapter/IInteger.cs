using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.GenericValueAdapter
{
    // Vector2f, Vector3i
    public interface IInteger
    {
        int Value { get; }
    }

}
