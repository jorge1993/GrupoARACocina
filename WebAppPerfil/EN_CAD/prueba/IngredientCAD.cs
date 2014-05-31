using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace prueba
{
    public class IngredientCAD
    {
        private string db = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Database1.mdf;User Instance=true";

        public IngredientCAD()
        {
        }


        // Insert into the database a new ingredient (It's necessary that its fields are not null)
        public bool InsertIngredient(IngredientEN item)
        {
            bool añadido;

            SqlConnection con = new SqlConnection(db);
            string sql = "INSERT INTO Ingredient (Name,Description) VALUES (" + item.Name + "," + item.Description + ")";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                añadido = true;
            }
            catch (Exception ex)
            {
                añadido = false;
            }
            finally
            {
                con.Close();
            }

            return añadido;

        }

        // Deletes the ingredient from the database that is passed by parameter
        public bool DeleteIngredient(IngredientEN item)
        {
            bool borrado;

            SqlConnection con = new SqlConnection(db);
            string sql = "DELETE FROM Ingredient WHERE Name = " + item.Name;
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                borrado = true;
            }
            catch (Exception ex)
            {
                borrado = false;
            }
            finally
            {
                con.Close();
            }

            return borrado;

        }

        // Returns a list with the recipes that use this ingredient
        public List<RecipeEN> ListRecipes(IngredientEN ing)
        {
            List<RecipeEN> recetas = new List<RecipeEN>();

            return recetas;
        }

        // Modify the description of an ingredient
        public void ModifyDescription(IngredientEN item, string description)
        {
            {
                SqlConnection con = new SqlConnection(db);
                string sql = "UPDATE Ingredient SET DATE = " + item.Name + ", DESCRIPTION = " + description + "WHERE Name = " + item.Name;
                SqlCommand cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch { }
                finally
                {
                    con.Close();
                }
            }
        }

        /***********/
        /** DATOS **/
        /***********

        //private Database db;
        private IngredientEN ingredient;
        private List<IngredientEN> ingredients;*/

    }
}