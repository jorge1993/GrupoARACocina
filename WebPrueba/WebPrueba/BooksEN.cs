using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class BooksEN
    {
        //Default constructor without parameters
        public BooksEN()
        {
            title = "";
            author = "";
            isbn = "";
            price = 0;
            date = "";
        }

        //Constructor only with the title (PK)
        public BooksEN(String t)
        {
            title = t;
            author = "";
            isbn = "";
            price = 0;
            date = "";
        }

        //Ctor with all the attributes
        public BooksEN(String t, String a, String i, int p, string d)
        {
            title = t;
            author = a;
            isbn = i;
            price = p;
            date = d;
        }

        //Function to add a new book
        public void insertBook(BookEN book)
        {
        }

        //Function to remove a book
        public void deleteBook()
        {
        }

        //Modify the price of a book
        public void changePrice()
        {
        }

        // Getter/Setter of title
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        // Getter/Setter of author
        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        // Getter/Setter of isbn
        public String Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // Getter/Setter of date
        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        /***********/
        /** DATOS **/
        /***********/
        private String title;
        private String author;
        private String isbn;
        private int price;
        private String date;

        private BooksCAD booksCAD;
    }
}