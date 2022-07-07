using System;

namespace Strategies
{
    public class HorselikeWalkingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("Створіння, яке виглядає як кінь, у процесі ходіння");
        }
    }
}
