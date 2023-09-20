using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OCP
{
    //ENTERPRISE PATTERN - SPECIFICATION PATTERN
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
