using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    public class Boo : IEntity
    {
        public string Name { get; set; }                
        public Boo()
        {
            this.Name = nameof(Boo);
        }

        public void Move()
        {
            Console.WriteLine("move 1");
        }
    }
}
