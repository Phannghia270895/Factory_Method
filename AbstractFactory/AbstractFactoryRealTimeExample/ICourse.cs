using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealTimeExample
{

    // The AbstractProductA interface
    // Each distinct product of the Course product family should have a base interface.
    // All variants of Course products must implement this ICourse interface.
    public interface ICourse
    {
        string GetCourseName();
        int GetCourseFee();
        string GetCourseDuration();
    }
}
