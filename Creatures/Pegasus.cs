using System;
using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public class Pegasus : Creature
    {
        public Pegasus()
        {
            Abilities = new List<MovementAbility>()
           {
               MovementAbility.Walk,
               MovementAbility.Fly
           };
        }
        public override void Attack()
        {
            Console.WriteLine("Пегас бьє декілька разів за допомогою міцних передніх ніг");
        }
        public override bool UpdateMovement(MovementAbility movementStrategy)
        {
            if (Abilities.Any(movement => movement == movementStrategy))
            {
                _movingStrategy = new StrategySelector().HorselikeMovement[movementStrategy];
                return true;
            }
            return false;
        }
    }
}
