using BookShop.BLL;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop
{
    public partial class ShowBookUi : System.Web.UI.Page
    {
        BookManager bookManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllBook();
        }

        private void ShowAllBook()
        {
            GridView.DataSource = bookManager.GetAllBook();
            GridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchBox.Text;
            SearchBook(name);
        }
        private void SearchBook(string name)
        {
            List<Book> bookList = new List<Book>();
            BookManager bookManager = new BookManager();
            bookList = bookManager.searchBook(name);
            GridView.DataSource = bookList;
            GridView.DataBind();

        }
    }
}