using System;
using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public class Vampire : Creature
    {
        public Vampire()
        {
            Abilities = new List<MovementAbility>()
           {
               MovementAbility.Walk,
               MovementAbility.Fly
           };
        }
        public override void Attack()
        {
            Console.WriteLine("Вампір накидується на жертву та кусає її");
        }
        public override bool UpdateMovement(MovementAbility movementStrategy)
        {
            if (Abilities.Any(movement => movement == movementStrategy))
            {
                _movingStrategy = new StrategySelector().HumanoidMovement[movementStrategy];
                return true;
            }
            return false;
        }
    }
}
