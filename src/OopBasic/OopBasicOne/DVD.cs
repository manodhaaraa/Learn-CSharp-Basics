using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasicOne
{
    public class DVD: LibraryItem
    {
        private double Duration { get; set; }
        public DVD(string title, string author, int itemId, double duration) : base(title, author, itemId)
        {
            Duration = duration;
        }
        public DVD(string title, int itemId, double duration) : base(title, itemId)
        {
            Duration = duration;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, Duration: {Duration}, Checked Out: {IsCheckedOut}");
        }

    }
}
