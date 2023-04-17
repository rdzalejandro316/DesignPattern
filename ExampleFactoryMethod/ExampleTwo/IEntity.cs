using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    public interface IEntity
    {
        string Name { get; set; }
        void Move();
    }
}
