using ExampleFactoryMethod.ExampleOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    class RandomDifficultEnemyFactory : IEnemyFactory
    {
        public IEntity CreateEnemy()
        {
            List<Type> enemys = new List<Type> { typeof(Boo), typeof(Goomba), typeof(Koopa) };
            Random rng = new Random();
            int index = rng.Next(enemys.Count);
            switch (index)
            {
                case 1: return new Boo();
                case 2: return new Goomba();
                case 3: return new Koopa();
                default: return new Boo();
            }
        }
    }
}
