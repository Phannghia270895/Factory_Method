using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{
    // The AbstractProductB interface
    // Each distinct product of the Source product family should have a base interface.
    // All variants of Source products must implement this ISource interface.
    public interface ISource
    {
        string GetSourceName();
    }
}
