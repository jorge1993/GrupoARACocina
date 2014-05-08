using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
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
        public void DeletesUser()
        {
        }

        // Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser()
        {
        }


        // Returns a list with the recipes that a user have done
        public List<Recipe> RecipesUser()
        {
        }

        // Returns a list with the comments that a user have done
        public List<Comment> CommentsUser()
        {
        }

        // Returns a list of the users that has equals or more puntation that the given by parameter
        public List<User> PuntuationUser(int puntuacion)
        {
        }

        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail()
        {
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick()
        {
        }

        public void voteRecipe(Recipe recipe, int vote)
        {

        }

        public void comment(Comment comment)
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
