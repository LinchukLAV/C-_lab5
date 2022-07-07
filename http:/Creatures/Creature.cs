using System.Collections.Generic;
using System.Linq;
using Strategies;
using Lab;

namespace Creatures
{
    public abstract class Creature
    {
        public string Name { get; set; } = string.Empty;
        public string CreatureType { get => this.GetType().ToString().Split(".").Last(); }
        public bool IsOnMagic { get; set; } = false;
        public IMovingStrategy _movingStrategy { get; protected set; }
        public List<MovementAbility> Abilities { get; set; } = new List<MovementAbility>();

        public abstract void Attack();
        public bool Move()
        {
            if (_movingStrategy is not null)
            {
                _movingStrategy.Move();
                return true;
            }
            return false;
        }
        public abstract bool UpdateMovement(MovementAbility movementStrategy);

        public override string ToString()
        {
            return $"{Name} раса: {CreatureType}";
        }
    }
}
