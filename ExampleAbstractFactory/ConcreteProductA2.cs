using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractFactory
{
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
