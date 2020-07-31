using BookShop.BLL;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop
{
    public partial class AddBookUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name   = inputBookName.Value;
            string isbn   = inputISBN.Value;
            string author = inputAuthor.Value;

            Book book = new Book(name, isbn, author);
            BookManager bookManager = new BookManager();
            bool isSaved=bookManager.saveBook(book);
            if(isSaved)
            {
                messageLabel.Text      = "Book Saved Successfully";
                messageLabel.ForeColor =  Color.Green;
            }
            else
            {
                messageLabel.Text      = "Book Does not Saved ";
                messageLabel.ForeColor = Color.Red; 
            }
        }
    }
}