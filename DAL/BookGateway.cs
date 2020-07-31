using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BookShop.DAL
{
    public class BookGateway
    {
        
        string connectionString = WebConfigurationManager.ConnectionStrings["BookShop"].ConnectionString;
        public bool InsertBook(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Book_tbl VALUES('"+book.BookName+"','"+book.ISBN+"','"+book.Author+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect=command.ExecuteNonQuery();
            connection.Close();
            if(rowEffect>0)
            {
                return true;
            }
            return false;
        }

        public List<Book> searchBook(string name)
        {
            List<Book> bookList = new List<Book>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Book_tbl WHERE BookName LIKE '%"+name+"%' ;";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int bookId = (int)reader["BookId"];
                string bookName = reader["BookName"].ToString();
                string isbn = reader["ISBN"].ToString();
                string author = reader["Author"].ToString();
                Book book = new Book(bookName, isbn, author);
                book.BookId = bookId;
                bookList.Add(book);
            }
            reader.Close();
            connection.Close();

            return bookList;
        }

        public List<Book> GetAllStudent()
        {
            List<Book> bookList = new List<Book>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Book_tbl order by  BookId desc ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int     bookId   = (int)reader["BookId"];
                string  bookName = reader["BookName"].ToString();
                string  isbn     = reader["ISBN"].ToString();
                string  author   = reader["Author"].ToString();
                Book book = new Book(bookName, isbn, author);
                book.BookId = bookId;
                bookList.Add(book);
            }
            reader.Close();
            connection.Close();
           
            return bookList;
        }
    }
}