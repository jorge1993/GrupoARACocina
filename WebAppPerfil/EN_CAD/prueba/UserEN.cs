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
    public class UserEN
    {

        // Constructor by default, without parameters
        public UserEN()
        {
            email = "";
            name = "";
            surname = "";
            country = "";
            age = 0;
            nick = "";
            password = "";
        }

        // Constructor with the parameters of a user
        public UserEN(string em, string na, string sur, string co, int ag, string ni, string pass)
        {
            email = em;
            name = na;
            surname = sur;
            country = co;
            age = ag;
            nick = ni;
            password = pass;
        }

        // Creates a new user
        public bool InsertUser()
        {
            UserCAD u = new UserCAD();
            return u.InsertUser(this);
        }

        // Erase a user
        public bool DeletesUser()
        {
            UserCAD u = new UserCAD();
            return u.InsertUser(this);
        }

        public UserEN Read()
        {
            UserCAD user = new UserCAD();
            return user.Read(this);            
        }

        // Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser()
        {
            UserCAD u = new UserCAD();
            return u.ValidationUser(this.email, this.password);
        }


        // Returns a list with the recipes that a user have done
        public List<RecipeEN> RecipesUser()
        {
            UserCAD u = new UserCAD();
            return u.RecipesUser(this);
        }


        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail()
        {
            UserCAD u = new UserCAD();
            return u.CheckEmail(email);
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick()
        {
            UserCAD u = new UserCAD();
            return u.CheckNick(nick);
        }

        public bool voteRecipe(RecipeEN recipe, int vote)
        {
            UserCAD u = new UserCAD();
            return u.VoteRecipe(this, recipe, vote);
            
        }

        public bool Comment(RecipeEN recipe, CommentEN comment)
        {
            UserCAD u = new UserCAD();
            return u.Comment(this, recipe, comment);
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        public string Country
        {
            get { return country; }
            set { country = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Nick
        {
            get { return nick; }
            set { nick = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /***********/
        /** DATOS **/
        /***********/

        private string email;
        private string name;
        private string surname;
        private string country;
        private int age;
        private string nick;
        private string password;

        private UserCAD user;
    }
}
