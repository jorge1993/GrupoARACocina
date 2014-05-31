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

//using Finisar.SQLite;

namespace prueba
{
    public class RecipeCAD
    {
        private string db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";


        public bool addRecipe(RecipeEN recipe)
        {
            bool added = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                try
                {
                    c.Open();
                    SqlCommand sentencia = new SqlCommand("SELECT MAX(Id) FROM Recipe", c);
                    SqlDataReader dr = sentencia.ExecuteReader();

                    //while (dr.Read())
                    //{
                    if (dr.Read())
                    {
                        recipe.Id = long.Parse(dr[0].ToString());
                        recipe.Id += 1;
                    }

                    dr.Close();
                }
                catch (Exception ex) { }
                finally
                {
                    c.Close();
                }

                c.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Recipe (Id, Name, Time, Subtitle, Description, Video, Origin, Difficulty, Type, Image, Usuario) VALUES (" +
                    recipe.Id + ", '" + recipe.Name + "', " + recipe.Time + ", '" + recipe.Subtitle + "', '" + recipe.Description + "', '" + recipe.Video +
                    "', '" + recipe.Origin + "', '" + recipe.Difficulty + "', '" + recipe.Type + "', '" + recipe.Imagen + "', '" + recipe.User.Email + "')", c);
                com.ExecuteNonQuery();
                added = true;
            }
            catch (Exception ex) { added = false; }
            finally
            {
                c.Close();
            }
            return added;
        }

        /*public bool updateRecipe(RecipeEN recipe, long id)
        {
        	bool updated = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("", c);
                com.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex) { updated=false;}
            finally
            {
                c.Close();
            }
            return updated;
        }*/

        public List<CommentEN> getComments(RecipeEN reci)
        {

            List<CommentEN> lista = new List<CommentEN>();
            CommentsCAD recipeCad = new CommentsCAD();
            CommentEN recipe;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT Code FROM Ternary WHERE Id = " + reci.Id, c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe = recipeCad.READ(long.Parse(dr["Id"].ToString()));

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

        public bool deleteRecipe(RecipeEN recipe)
        {
            bool delete = false;
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Recipe WHERE NICK = '" + recipe.Id + "'", c);
                com.ExecuteNonQuery();
                delete = true;
            }
            catch (Exception ex) { delete = false; }
            finally { c.Close(); }
            return delete;
        }

        public BookEN getBook(RecipeEN recipe)
        {
            BookEN book = new BookEN();
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT FROM Book WHERE Title = '" + recipe.Book + "'", c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    book.Author = dr["Author"].ToString();
                    book.Date = dr["Date"].ToString();
                    book.Isbn = dr["Isbn"].ToString();
                    book.Title = dr["Title"].ToString();
                }
            }
            catch (Exception ex) { }
            finally { c.Close(); }
            return book;
        }

        public RecipeEN getRecipe(long id)
        {
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Id = '" + id + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    dr.Close();
                }
            }
            catch (Exception ex) { }
            finally
            {
                c.Close();
            }
            return recipe;
        }


        private List<RecipeEN> getRecipesName(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Name = '" + reci.Name + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }

        private List<RecipeEN> getRecipesHard(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);
            string s = "";
            if (reci.Name != "") s = "and Name = " + reci.Name;

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Difficulty = 'Hard'" + s + "", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }


        private List<RecipeEN> getRecipesImpossible(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);
            string s = "";
            if (reci.Name != "") s = "and Name = " + reci.Name;

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Difficulty = 'Impossible'" + s + "", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }

        private List<RecipeEN> getRecipesMedium(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);
            string s = "";
            if (reci.Name != "") s = "and Name = " + reci.Name;

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Difficulty = 'Medium'" + s + "", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }

        private List<RecipeEN> getRecipesEasy(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);
            string s = "";
            if (reci.Name != "") s = "and Name = " + reci.Name;

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Difficulty = 'Easy'" + s + "", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }

        private List<RecipeEN> getRecipesAuth(RecipeEN reci)
        {
            List<RecipeEN> recipes = new List<RecipeEN>();
            RecipeEN recipe = new RecipeEN();
            SqlConnection c = new SqlConnection(db);

            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Recipe WHERE Author = '" + reci.User + "'", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    recipe.Id = int.Parse(dr["Id"].ToString());
                    recipe.Name = dr["Name"].ToString();
                    recipe.Time = int.Parse(dr["Time"].ToString());
                    recipe.Subtitle = dr["Subtitle"].ToString();
                    recipe.Description = dr["Description"].ToString();
                    recipe.Video = dr["Video"].ToString();
                    recipe.Origin = dr["Origin"].ToString();
                    recipe.Difficulty = dr["Difficulty"].ToString();
                    recipe.Type = dr["Type"].ToString();
                    recipe.Imagen = dr["Imagen"].ToString();
                    recipes.Add(recipe);
                }
                dr.Close();
            }
            catch (Exception ex) { }
            finally { c.Close(); }

            return recipes;
        }

        public List<RecipeEN> getRecipes(string tipoBusqueda, RecipeEN reci)
        {
            List<RecipeEN> fr = new List<RecipeEN>();
            SqlConnection c = new SqlConnection(db);

            try
            {
                c.Open();
                switch (tipoBusqueda)
                {
                    case "Name":
                        return getRecipesName(reci);
                        break;
                    case "Hard":
                        return getRecipesHard(reci);
                        break;
                    case "Impossible":
                        return getRecipesImpossible(reci);
                        break;
                    case "Middle":
                        return getRecipesMedium(reci);
                        break;
                    case "Author":
                        return getRecipesAuth(reci);
                        break;
                }
            }
            catch (Exception ex) { }
            finally { c.Close(); }
            return fr;
        }
    }
}