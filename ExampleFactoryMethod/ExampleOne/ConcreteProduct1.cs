﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleOne
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return $"**Result of {nameof(ConcreteProduct1)}**";
        }
    }
}
