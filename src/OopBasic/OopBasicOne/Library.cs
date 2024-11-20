using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasicOne
{
    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
            Console.WriteLine($"Added '{item.Title}' to the library.");
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\nLibrary Inventory:");
            foreach (var item in items)
            {
                item.ShowInfo();
            }
        }

        public LibraryItem FindItemById(int itemId)
        {
            return items.Find(item => item.ItemId == itemId);
        }
    }
}
