using System;
using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public class Troll : Creature
    {
        public Troll()
        {
            Abilities = new List<MovementAbility>()
           {
               MovementAbility.Walk
           };
        }
        public override void Attack()
        {
            Console.WriteLine("Троль атакує за допомогою топора");
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
