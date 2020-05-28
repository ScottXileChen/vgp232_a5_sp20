using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO: initialize the inventory
            Inventory inventory = new Inventory(10);
            // Add a few items
            Item sword = new Item("Sword", 10, ItemType.equipment);
            Item apple = new Item("Apple", 1, ItemType.consumable);
            Item gun = new Item("Gun", 50, ItemType.equipment);
            Item key1 = new Item("First floor Key", 1, ItemType.key);
            Item key2 = new Item("Second floor Key", 1, ItemType.key);
            inventory.Add(sword);
            inventory.Add(apple);
            inventory.Add(gun);
            inventory.Add(key1);
            inventory.Add(key2);
            // Remove a few items
            inventory.ShowInventory();
            inventory.Remove(gun);
            // show the inventory.
            Console.WriteLine();
            inventory.ShowInventory();
            Console.ReadKey();
        }
    }
}
