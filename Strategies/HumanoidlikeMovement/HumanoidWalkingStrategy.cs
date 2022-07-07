using System;

namespace Strategies
{
    public class HumanoidWalkingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("Створіння схожа на людину у процесі ходіння");
        }
    }
}
