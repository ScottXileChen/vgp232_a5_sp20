using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        List<Item> items;

        public Inventory(int slots)
        {
            this.slots = slots;
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            if (items.Count >= slots)
            {
                Console.WriteLine("No slot to add item!");
                return;
            }
            // TODO: add implementation.
            items.Add(item);
            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty!");
                return;
            }
            // TODO: add implementation.
            items.Remove(item);
            //throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            if(items.Count == 0)
            {
                Console.WriteLine("Inventory is empty!");
                return;
            }
            // TODO: add implementation.
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Modifier: {item.Modifier}, Type: {item.IType}");
            }
            //throw new NotImplementedException();
        }
    }
}
