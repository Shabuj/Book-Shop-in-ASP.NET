using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Book
    {
        public int BookId { set; get; }
        public string BookName { set; get; }
        public string ISBN { set; get; }
        public string Author { set; get; }

        public Book(string BookName, string ISBN, string Author)
        {
            this.BookName = BookName;
            this.ISBN     = ISBN;
            this.Author   = Author;
        }
    }
}