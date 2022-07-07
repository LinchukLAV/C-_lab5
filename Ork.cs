using System;
using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public class Ork : Creature
    {
        public Ork()
        {
            Abilities = new List<MovementAbility>()
           {
               MovementAbility.Walk
           };
        }
        public override void Attack()
        {
            Console.WriteLine("Орк атакує з дуже великою силою, використовуючи при цьому біту");
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
