using System;
using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public class Harpy : Creature
    {
        public Harpy()
        {
            Abilities = new List<MovementAbility>()
            {
                MovementAbility.Fly
            };
        }
        public override void Attack()
        {
            Console.WriteLine("Гарпія бьє декілька разів за допомогою потоку вітру від крил");
        }
        public override bool UpdateMovement(MovementAbility movementStrategy)
        {
            if (Abilities.Any(movement => movement == movementStrategy))
            {
                _movingStrategy = new StrategySelector().BirdlikeMovement[movementStrategy];
                return true;
            }
            return false;
        }
    }
}
