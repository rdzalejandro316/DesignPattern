using ExampleFactoryMethod.ExampleOne;
using ExampleFactoryMethod.ExampleTwo;
using System;

namespace ExampleFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example one 
            //new Client().Main();


            //example two 
            var game = new Game(new RandomEnemyFactory());
            game.gameLogic();


        }
    }
}
