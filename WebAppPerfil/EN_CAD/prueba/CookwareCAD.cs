using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//using Finisar.SQLite;

namespace prueba
{
    public class CookwareCAD
    {
        private string db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";
        public CookwareCAD()
        {

        }

        public bool addCookware(CookwareEN e)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Cookware VALUES (" + e.Name + ", " + e.Material + "," + e.Imagen + ")", c);
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

        public CookwareEN READ(int cod)
        {
            return (null);
        }

        public bool deleteCookware(CookwareEN delete)
        {
            bool deleted = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Cookware WHERE Name = " + delete.Name + " AND Material = " + delete.Material, c);
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

        public CookwareEN getCookware(string name, string material)
        {
            CookwareEN cook = new CookwareEN();
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Cookware WHERE Name = " + name + " AND Material = " + material + ")", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    cook.Name = dr["Name"].ToString();
                    cook.Material = dr["Material"].ToString();
                    dr.Close();
                }
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return cook;
        }

        public List<CookwareEN> getCookwares()
        {
            List<CookwareEN> cookwareList = new List<CookwareEN>();

            String sql = "SELECT * FROM Cookware";
            // string sql = "SELECT * FROM NOTES ORDER BY ID DESC";
            SqlConnection con = new SqlConnection(db);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                CookwareEN cookwareTemp = new CookwareEN();

                while (reader.Read())
                {
                    cookwareTemp = new CookwareEN();

                    cookwareTemp.Name = reader["Name"].ToString();
                    cookwareTemp.Material = reader["Material"].ToString();

                    cookwareList.Add(cookwareTemp);
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }


            return cookwareList;
        }
    }
}
