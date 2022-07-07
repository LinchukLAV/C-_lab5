using System;

namespace Strategies
{
    public class HumanoidFlyingStrategy : IMovingStrategy
    {
        public void Move()
        {
            Console.WriteLine("Гуманоїд знаходиться в повітрі");
        }
    }
}
