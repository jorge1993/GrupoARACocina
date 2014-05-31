using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace prueba
{
    public class UserCAD
    {

    	public UserCAD()
    	{
    	}

    	// Inserts a user on the database
    	public void InsertUser(UserEN user)
    	{
    	}

    	// Deletes as user from the database
    	public void DeletesUser(UserEN user)
    	{
    	}

    	// Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser(string email, string password)
        {
            bool ok = true;

            return ok;
        }


	 	// Returns a list with the recipes that a user have done
        public List<RecipeEN> RecipesUser(UserEN user)
        {
            List<RecipeEN> recetas = new List<RecipeEN>();

            return recetas;
        }

        // Returns a list with the comments that a user have done
        public List<CommentEN> CommentsUser(UserEN user)
        {
            List<CommentEN> comentarios = new List<CommentEN>();

            return comentarios;
        }

        // Returns a list of the users that has equals or more puntation that the given by parameter
        public List<UserEN> PuntuationUser(int puntuacion)
        {
            List<UserEN> puntuaciones = new List<UserEN>();

            return puntuaciones;
        }

        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail(string email)
        {
            bool ok = true;

            return ok;
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick(string nick)
        {
             bool ok = true;

            return ok;
        }

        public void voteRecipe(UserEN user, RecipeEN recipe, int vote)
        {

        }

        public void comment(UserEN user, CommentEN comment)
        {

        }



    	/***********/
        /** DATOS **/
        /***********/

        //private Database db;
        private UserEN user;
        private List<UserEN> users;
    }

 }
