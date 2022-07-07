using System.Collections.Generic;
using Creatures;
using Strategies;

namespace Lab
{
    public class StrategySelector
    {
        public Dictionary<MovementAbility, IMovingStrategy> HumanoidMovement { get; }
            = new Dictionary<MovementAbility, IMovingStrategy>()
            {
                [MovementAbility.Walk] = new HumanoidWalkingStrategy(),
                [MovementAbility.Fly] = new HumanoidFlyingStrategy()
            };
        public Dictionary<MovementAbility, IMovingStrategy> BirdlikeMovement { get; }
            = new Dictionary<MovementAbility, IMovingStrategy>()
            {
                [MovementAbility.Fly] = new BirdlikeFlyingStrategy()
            };
        public Dictionary<MovementAbility, IMovingStrategy> HorselikeMovement { get; }
            = new Dictionary<MovementAbility, IMovingStrategy>()
            {
                [MovementAbility.Walk] = new HorselikeWalkingStrategy(),
                [MovementAbility.Fly] = new HorselikeFlyingStrategy()
            };
        public Dictionary<MovementAbility, IMovingStrategy> VampireMovement { get; }
            = new Dictionary<MovementAbility, IMovingStrategy>()
            {
                [MovementAbility.Walk] = new HumanoidWalkingStrategy(),
                [MovementAbility.Fly] = new BirdlikeFlyingStrategy()
            };
    }
}
