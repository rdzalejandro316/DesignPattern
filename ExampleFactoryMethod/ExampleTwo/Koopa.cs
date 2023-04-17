using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleFactoryMethod.ExampleTwo
{
    public class Koopa : IEntity
    {
        public string Name { get; set; }                
        public Koopa()
        {
            this.Name = nameof(Koopa);
        }

        public void Move()
        {
            Console.WriteLine("move 2");
        }
    }
}
