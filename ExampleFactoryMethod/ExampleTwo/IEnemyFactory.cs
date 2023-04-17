using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    public interface IEnemyFactory
    {
        IEntity CreateEnemy();
    }
}
