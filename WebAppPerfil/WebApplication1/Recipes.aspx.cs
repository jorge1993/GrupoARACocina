using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prueba;

namespace WebApplication1
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                Response.Redirect("RecetaVer.aspx");
            }
        }

        protected void do_search(object sender, EventArgs e)
        {
            RecipeEN receta = new RecipeEN();

            string text = "";
            

            string num = DropDownList1.SelectedIndex.ToString();

            List<RecipeEN> recetas = new List<RecipeEN>();

            if (num == "0")
            {
                if (TextBox1.Text != "")
                {
                    text = "WHERE (Name LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] "+ text +" ORDER BY [Name] ";
            }

            else if (num == "1")
            {
                if (TextBox1.Text != "")
                {
                    text = "WHERE (Author LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] "+text+" ORDER BY [Author] ";
            }

            else if (num == "2")
            {
                if (TextBox1.Text != "")
                {
                    text = "AND (Name LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] WHERE ([Difficulty] = 'Easy') "+ text +" ORDER BY [Name] ";

            }

            else if (num == "3")
            {
                if (TextBox1.Text != "")
                {
                    text = "AND (Name LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] WHERE ([Difficulty] = 'Medium') " + text + " ORDER BY [Name] ";

            }

            else if (num == "4")
            {
                if (TextBox1.Text != "")
                {
                    text = "AND (Name LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] WHERE ([Difficulty] = 'Hard') " + text + " ORDER BY [Name] ";

            }

            else if (num == "5")
            {
                if (TextBox1.Text != "")
                {
                    text = "AND (Name LIKE '%" + TextBox1.Text + "%') ";
                }
                SqlDataSource1.SelectCommand = "SELECT [Image], [Name], [Time], [Difficulty] FROM [Recipe] WHERE ([Difficulty] = 'Impossible') "+ text +" ORDER BY [Name] ";

            }


        }


    }
}