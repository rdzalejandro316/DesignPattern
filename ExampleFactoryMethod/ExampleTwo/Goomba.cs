using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    public class Goomba : IEntity
    {
        public string Name { get; set; }                
        public Goomba()
        {
            this.Name = nameof(Goomba);
        }

        public void Move()
        {
            Console.WriteLine("move 3");
        }
    }
}
