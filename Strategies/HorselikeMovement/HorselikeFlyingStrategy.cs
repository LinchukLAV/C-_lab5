using System;

namespace Strategies
{
    public class HorselikeFlyingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("Створіння, схоже на коня, летить");
        }
    }
}
