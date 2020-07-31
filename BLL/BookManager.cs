using BookShop.DAL;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.BLL
{
    public class BookManager
    {
        BookGateway gateway = new BookGateway();
        public bool saveBook(Book book)
        {
            if(book.ISBN.Length==13)
            {
                return gateway.InsertBook(book) ;
            }
            return false;
        }

        public List<Book>  GetAllBook()
        {
            return gateway.GetAllStudent();
        }

        public List<Book> searchBook(string name)
        {

            return gateway.searchBook(name);
        }
    }
}