using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba
{
    public class BookEN
    {

        //Default constructor without parameters
        public BookEN()
        {
            title = "";
            author = "";
            isbn = "";
            price = 0;
            date = "";
        }

        //Constructor only with the title (PK)
        public BookEN(string t)
        {
            title = t;
            author = "";
            isbn = "";
            price = 0;
            date = "";
        }

        //Ctor with all the attributes
        public BookEN(string t, string a, string i, int p, string d)
        {
            title = t;
            author = a;
            isbn = i;
            price = p;
            date = d;
        }

        //Function to add a new book
        public void insertBook()
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
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Getter/Setter of author
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // Getter/Setter of isbn
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // Getter/Setter of date
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        /***********/
        /** DATOS **/
        /***********/
        private string title;
        private string author;
        private string isbn;
        private int price;
        private string date;

        private BookCAD BookCAD;

    }
}
