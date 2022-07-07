using System;
using System.Collections.Generic;

namespace MenuItems
{

    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public int ItemsCount { get { return Items.Count; } }
        public bool IsExitWanted { get; set; }

        public Menu()
        {
            IsExitWanted = false;
            Items = new();
        }

        public void PrintMenu(string? title)
        {
            if (title is not null)
            {
                Console.WriteLine($"{title}\n");
            }
            foreach (MenuItem menuItem in Items)
            {
                Console.WriteLine(menuItem);
            }
        }

        public void Pause()
        {
            Console.WriteLine("Для продовження натисніть будь-яку клавішу");
            Console.ReadKey();
        }

        public void ExecuteSelectedItem(int itemIndex)
        {
            Items[itemIndex].ExecuteSelectedAction();
        }
    }
}
