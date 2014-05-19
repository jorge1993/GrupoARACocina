using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



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
        public void InsertUser()
        {
        }

        // Erase a user
        public void DeleteUser()
        {
        }

        // Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser()
        {
            bool ok = true;

            return ok;
        }


        // Returns a list with the recipes that a user have done
        public List<RecipeEN> RecipesUser()
        {
            List<RecipeEN> recetas = new List<RecipeEN>();

            return recetas;
        }

        // Returns a list with the comments that a user have done
        public List<CommentEN> CommentsUser()
        {
            List<CommentEN> comments = new List<CommentEN>();

            return comments;
        }

        // Returns a list of the users that has equals or more puntation that the given by parameter
        public List<UserEN> PuntuationUser(int puntuacion)
        {
            List<UserEN> users = new List<UserEN>();

            return users;
        }

        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail()
        {
            bool ok = true;

            return ok;
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick()
        {
            bool ok = true;

            return ok;
        }

        public void voteRecipe(RecipeEN recipe, int vote)
        {

        }

        public void comment(CommentEN comment)
        {

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
