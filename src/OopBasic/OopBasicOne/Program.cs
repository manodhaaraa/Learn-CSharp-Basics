// See https://aka.ms/new-console-template for more information


using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace OopBasicOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding items
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 2, 180);
            var dvd = new DVD("Inception", "Christopher Nolan", 1, 2.5);

            library.AddItem(book);
            library.AddItem(dvd);

            // Display all items
            library.DisplayAllItems();

            // Check out a book
            book.CheckOut();

            // Attempt to check out the same book
            book.CheckOut();

            // Return the book
            book.ReturnItem();

            // Find and display a specific item
            var foundItem = library.FindItemById(1);
            if (foundItem != null)
            {
                Console.WriteLine("\nFound Item:");
                foundItem.ShowInfo();

            }

            // Display all items after operations
            library.DisplayAllItems();
        }
    }
}