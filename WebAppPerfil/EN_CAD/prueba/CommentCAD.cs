using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;

namespace prueba
{
    public class CommentsCAD
    {
        private string db;        

        public CommentsCAD()
        {
            db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";
        }

        public bool INSERT(CommentEN e)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Comment (Code, Date, Description)" +
                                                " VALUES (" + e.Code + ", " + e.Date + ", '" + e.Description + ")", c);
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

        public CommentEN READ(long code)
        {

            CommentEN comment = new CommentEN();
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Comment WHERE email = " + code + "", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    comment.Code = Int32.Parse(dr["Code"].ToString());
                    comment.Date = DateTime.Parse(dr["Date"].ToString());
                    comment.Description = dr["Description"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }

            return comment;
        }

        public bool UPDATE(CommentEN c)
        {

            bool updated = false;
            SqlConnection sql = new SqlConnection(db);
            try
            {
                sql.Open();
                SqlCommand com = new SqlCommand("UPDATE Comment SET Date = " + c.Date + ", Description =  '" + c.Description + "'"
                    + "WHERE Code = " + c.Code, sql);
                com.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex) { }
            finally
            {
                sql.Close();
            }
            return updated;
        }

        public bool DELETE(long code)
        {
            bool deleted = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Comment WHERE Code = " + code, c);
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
    }
}
