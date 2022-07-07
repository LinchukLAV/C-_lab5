using System;
using System.Collections.Generic;
using System.Linq;
using Creatures;
using MenuItems;

namespace Controllers
{
    public class GroupController
    {
        public List<Creature> MainCreatures { get; set; } = new List<Creature>();

        public void UseController()
        {
            Menu unitMenu = new Menu();
            unitMenu.Items = new List<MenuItem>()
            {
                new MenuItem("1. Атакувати створінням", () =>
                {
                    foreach(Creature creature in MainCreatures)
                    {
                        creature.Attack();
                    }
                }),
                new MenuItem("2. Рухатись", () =>
                {
                    foreach(Creature creature in MainCreatures)
                    {
                        if(!creature.Move())
                        {
                            Console.WriteLine("Створіння ще не вміє рухатись");
                        }
                    }
                }),
                new MenuItem("3. Накласти закляття", () =>
                {
                    foreach(Creature creature in MainCreatures)
                    {
                        CastSpell(creature);
                    }
                    Console.WriteLine("Закляття на політ накладено");
                }),
                new MenuItem("4. Зняти закляття", () =>
                {
                    foreach(Creature creature in MainCreatures)
                    {
                        UnCastSpell(creature);
                    }
                    Console.WriteLine("Закляття на політ знято");
                }),
                new MenuItem("5. Встановити значення руху за замовчуванням", () =>
                {
                    foreach(Creature creature in MainCreatures)
                    {
                        SetDefaultMovement(creature);
                    }
                    Console.WriteLine("Значення руху за замовчуванням встановлено");
                }),
                new MenuItem("6. Вихід", () => unitMenu.IsExitWanted = true)
            };

            MenuItemSelector selector = new MenuItemSelector(1, 6);

            while (!unitMenu.IsExitWanted)
            {
                Console.Clear();
                unitMenu.PrintMenu(null);

                Console.WriteLine("\nВаші персонажи");
                foreach (Creature creature in MainCreatures)
                {
                    Console.WriteLine(creature);
                }

                unitMenu.ExecuteSelectedItem(selector.SelectItem());
                unitMenu.Pause();
            }
        }

        private void CastSpell(Creature creature)
        {
            if (!creature.IsOnMagic)
            {
                creature.IsOnMagic = true;
                creature.Abilities.Add(MovementAbility.Fly);
                creature.UpdateMovement(MovementAbility.Fly);
            }
        }
        private void UnCastSpell(Creature creature)
        {
            if (creature.IsOnMagic)
            {
                creature.IsOnMagic = false;
                creature.Abilities.Remove(MovementAbility.Fly);
                SetDefaultMovement(creature);
            }
        }
        private void SetDefaultMovement(Creature creature)
        {
            creature.UpdateMovement(creature.Abilities[0]);
        }
    }
}
