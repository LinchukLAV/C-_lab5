using System;
using System.Collections.Generic;
using Creatures;
using Controllers;
using MenuItems;

namespace Lab
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CharacterSelector characterSelector = new CharacterSelector();
            MenuItemSelector mainMenuSelector = new MenuItemSelector(1, 3);

            Menu mainMenu = new Menu();
            mainMenu.Items = new List<MenuItem>()
            {
                new MenuItem("1. Грати за одного персонажа", () =>
                {
                    UnitController unitController = new UnitController();
                    unitController.MainCharacter = characterSelector.SelectCharacter();
                    unitController.UseController();
                }),
                new MenuItem("2. Грати за групу персонажів", () =>
                {
                    GroupController groupController = new GroupController();
                    Menu groupMenu = new Menu();
                    groupMenu.Items = new List<MenuItem>()
                    {
                        new MenuItem("1. Додати персонажа", () =>
                            groupController.MainCreatures.Add(characterSelector.SelectCharacter())),
                        new MenuItem("2. Зберігти", () =>
                        {
                            groupMenu.IsExitWanted = true;
                            groupController.UseController();
                        })
                    };

                    MenuItemSelector groupMenuSelector = new MenuItemSelector(1, 2);

                    while(!groupMenu.IsExitWanted)
                    {
                        Console.Clear();
                        groupMenu.PrintMenu("Меню створення групи");

                        groupMenu.ExecuteSelectedItem(groupMenuSelector.SelectItem());
                    }
                }),
            };

            mainMenu.PrintMenu("Головне меню програми");
            mainMenu.ExecuteSelectedItem(mainMenuSelector.SelectItem());
        }
    }
}