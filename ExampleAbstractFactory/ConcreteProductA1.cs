using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractFactory
{
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
