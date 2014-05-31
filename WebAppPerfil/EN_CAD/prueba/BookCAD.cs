using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace prueba
{
    public class BookCAD
    {
        private string db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";

        //Ctor without parameters
        public BookCAD()
        {
        }


        //Function to add a new book
        public bool insertBook(BookEN book)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Book VALUES (" + book.Title + ", " + book.Author + "," + book.Isbn + "," + book.Date + ")", c);
                com.ExecuteNonQuery();
                added = true;
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return added;

        }

        //Function to remove a book
        public bool deleteBook(string isbn)
        {
            bool deleted = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Book WHERE Isbn = " + isbn, c);
                com.ExecuteNonQuery();
                deleted = true;
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return deleted;
        }

        //get all the books
        public List<BookEN> getCookwares()
        {
            List<BookEN> books = new List<BookEN>();

            String sql = "SELECT * FROM Book";
            // string sql = "SELECT * FROM NOTES ORDER BY ID DESC";
            SqlConnection con = new SqlConnection(db);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                BookEN bookTemp = new BookEN();

                while (reader.Read())
                {
                    bookTemp = new BookEN();

                    bookTemp.Author = reader["Author"].ToString();
                    bookTemp.Date = reader["Date"].ToString();
                    bookTemp.Isbn = reader["Isbn"].ToString();
                    bookTemp.Title = reader["Title"].ToString();

                    books.Add(bookTemp);
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }


            return books;
        }

        /***********/
        /** DATOS **/
        /***********/

        //private Database db;
        private BookEN booksEN;

    }
}
