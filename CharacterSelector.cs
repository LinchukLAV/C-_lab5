using System;
using System.Collections.Generic;
using Creatures;
using MenuItems;

namespace Lab
{
    public class CharacterSelector
    {
        private Dictionary<int, Creature> Characters = new Dictionary<int, Creature>()
        {
            [0] = new Elf(),
            [1] = new Harpy(),
            [2] = new Ork(),
            [3] = new Pegasus(),
            [4] = new Troll(),
            [5] = new Vampire()
        };

        public Creature SelectCharacter()
        {
            Console.Clear();
            int i = 1;
            foreach (Creature creature in Characters.Values)
            {
                Console.WriteLine($"{i++}. {creature.CreatureType}");
            }
            Creature character = Characters[new MenuItemSelector(1, Characters.Count).SelectItem()];
            Console.WriteLine("Введіть ім'я персонажа: ");
            character.Name = Console.ReadLine() ?? "No name entered";
            return character;
        }
    }
}
