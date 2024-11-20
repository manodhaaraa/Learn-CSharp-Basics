

using System.Reflection;

namespace OopBasicOne
{
    public abstract class LibraryItem
    {
        public string Title { get; protected set; }
        public string? Author { get; protected set; }
        public int ItemId { get; protected set; }
        public bool IsCheckedOut { get; protected set; }
        public LibraryItem(string title, int itemId) { 
            Title = title;
            ItemId = itemId;
            IsCheckedOut = false;
        }
        public LibraryItem(string title, string author, int itemId)
        {
            Title = title;
            Author = author;
            ItemId = itemId;
            IsCheckedOut = false;
        }

        public abstract void ShowInfo();

        public void CheckOut()
        {
            if (IsCheckedOut)
            {
                Console.WriteLine($"Item '{Title}' is already checked out.");
                return;
            }
            IsCheckedOut = true;
            Console.WriteLine($"Item '{Title}' has been checked out.");

        }
        public void ReturnItem()
        {
            if (!IsCheckedOut)
            {
                Console.WriteLine($"Item '{Title}' is not checked out.");
                return;
            }

            IsCheckedOut = false;
            Console.WriteLine($"Item '{Title}' has been returned.");
        }
    }
}
