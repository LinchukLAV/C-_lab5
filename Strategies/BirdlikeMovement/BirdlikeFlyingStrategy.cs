using System;

namespace Strategies
{
    public class BirdlikeFlyingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("Створіння схоже на птицю летить");
        }
    }
}
