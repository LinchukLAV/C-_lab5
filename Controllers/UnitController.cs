using System;
using System.Collections.Generic;
using Creatures;
using MenuItems;

namespace Controllers
{
    public class UnitController
    {
        public Creature MainCharacter { get; set; }

        public void UseController()
        {
            Menu unitMenu = new Menu();
            unitMenu.Items = new List<MenuItem>()
            {
                new MenuItem("1. Атакувати створінням", () => MainCharacter.Attack()),
                new MenuItem("2. Рухатись", () =>
                {
                    if(!MainCharacter.Move())
                    {
                         Console.WriteLine("Створіння ще не вміє рухатись");
                    }
                }),
                new MenuItem("3. Спробувати змусити створіння ходити", () =>
                {
                    if (MainCharacter.UpdateMovement(MovementAbility.Walk))
                    {
                        Console.WriteLine("Спосіб руху оновлено");
                    }
                    else
                    {
                        Console.WriteLine("Створіння так не вміє");
                    }
                }),
                new MenuItem("4. Змусити створіння літати", () =>
                {
                    if (MainCharacter.UpdateMovement(MovementAbility.Fly))
                    {
                        Console.WriteLine("Спосіб руху оновлено");
                    }
                    else
                    {
                        Console.WriteLine("Створіння так не вміє");
                    }
                }),
                new MenuItem("5. Вихід", () => unitMenu.IsExitWanted = true)
            };

            MenuItemSelector selector = new MenuItemSelector(1, 5);

            while (!unitMenu.IsExitWanted)
            {
                Console.Clear();
                unitMenu.PrintMenu($"Ви наразі граєте за: {MainCharacter}");

                unitMenu.ExecuteSelectedItem(selector.SelectItem());
                unitMenu.Pause();
            }
        }
    }
}
