using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;


namespace prueba
{
    public class CommentEN
    {
        private long code;
        private DateTime date;
        private string description;

        public CommentEN()
        {
            code = 0;
            date = DateTime.Now;
            description = "";
        }

        public CommentEN(long c, DateTime t, string d)
        {
            code = c;
            date = t;
            description = d;
        }

        public long Code
        {
            get { return code; }
            set { code = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public bool INSERT()
        {
            CommentsCAD u = new CommentsCAD();
            return u.INSERT(this);
        }

        public CommentEN READ(long cod)
        {
            CommentsCAD u = new CommentsCAD();
            return u.READ(cod);
        }

        public bool UPDATE()
        {
            CommentsCAD u = new CommentsCAD();
            return u.UPDATE(this);
        }

        public bool DELETE()
        {
            CommentsCAD u = new CommentsCAD();
            return u.DELETE(this.code);

        }

    }
}
