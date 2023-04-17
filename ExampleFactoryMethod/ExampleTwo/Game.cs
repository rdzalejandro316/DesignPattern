using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading;

namespace ExampleFactoryMethod.ExampleTwo
{
    public class Game
    {
        private IEnemyFactory enemyFactory;
        public Game(IEnemyFactory _enemyFactory)
        {
            enemyFactory = _enemyFactory;
        }

        public void gameLogic() 
        {
            var enemy = enemyFactory.CreateEnemy();
            Console.Write($"ENEMY CREATED {enemy.Name}");
            
        }


    }
}
