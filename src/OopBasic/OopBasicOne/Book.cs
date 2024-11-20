using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OopBasicOne
{
    public class Book : LibraryItem
    {
        private int Pages {  get; set; }
        public Book(string title, string author, int itemId, int pages) : base(title, author, itemId)
        {
            Pages = pages;
        }
        public Book(string title, int itemId, int pages) : base(title, itemId)
        {
            Pages = pages;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, Pages: {Pages}, Checked Out: {IsCheckedOut}");
        }
    }
}
