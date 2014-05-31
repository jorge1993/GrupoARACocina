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
    public class UserCAD
    {
        private string db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";

        public UserCAD()
        {}

        public UserEN Read(UserEN u)
        {
            UserEN user = new UserEN();
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Users WHERE email = '" + u.Email + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    user.Email = dr["Email"].ToString();
                    user.Name = dr["Name"].ToString();
                    user.Surname = dr["Surname"].ToString();
                    user.Country = dr["Country"].ToString();
                    user.Age = Int32.Parse(dr["Age"].ToString());
                    user.Nick = dr["Nick"].ToString();
                    user.Password = dr["Password"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex) {}
            finally
            {
                c.Close();
            }

            return user;
        }

        // Inserts a user on the database
        public bool InsertUser(UserEN u)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                string comando = "INSERT INTO Users (Email, Name, Surname, Country, Age, Nick, Password) VALUES ('" + u.Email + "', '" + u.Name + "', '" + u.Surname + "', '" + u.Country +
                                                "', " + u.Age + ", '" + u.Nick + "', '" + u.Password + "')";
                SqlCommand com = new SqlCommand(comando, c);
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

        // Deletes as user from the database
        public bool DeleteUser(UserEN u)
        {
            bool deleted = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Users WHERE Email = '" + u.Email + "'", c);
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

        // Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser(string email, string password)
        {
            bool found = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT 1 FROM Users WHERE Email = '" + email + "' and Password = '" + password + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    found = true;
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return found;
        }


        // Returns a list with the recipes that a user have done
        public List<RecipeEN> RecipesUser(UserEN user)
        {
            List<RecipeEN> lista = new List<RecipeEN>();
            RecipeCAD recipeCad = new RecipeCAD();
            RecipeEN recipe;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT Id FROM Recipe WHERE User = '" + user.Email + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe = recipeCad.getRecipe(long.Parse(dr["Id"].ToString()));

                    lista.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return lista;
        }


        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail(string email)
        {
            bool found = false;
            SqlConnection c = new SqlConnection(db);
            
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Users WHERE Email = '" + email + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    found = true;
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return found;
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick(string nick)
        {
            bool found = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT 1 FROM User WHERE Nick = '" + nick + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    found = true;
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return found;
        }

        public bool VoteRecipe(UserEN u, RecipeEN r, int vote)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Puntuation (Email, Id, Puntuation)" +
                                                " VALUES ('" + u.Email + "', " + r.Id + ", " + vote + ")", c);
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

        public bool Comment(UserEN u, RecipeEN r, CommentEN c)
        {

            bool added = false;
            SqlConnection sql = new SqlConnection(db);
            try
            {
                sql.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Ternary (Email, Id, Code)" +
                                                " VALUES ('" + u.Email + "', " + r.Id + ", " + c.Code + ")", sql);
                com.ExecuteNonQuery();
                added = true;
            }
            catch (Exception ex) { }
            finally
            {
                sql.Close();
            }
            return added;
        }

    }

}
