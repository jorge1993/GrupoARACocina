using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class UserCAD
    {

    	public UserCAD()
    	{
    	}

    	// Inserts a user on the database
    	public void InsertUser(UserEn u)
    	{
    	}

    	// Deletes as user from the database
    	public void DeletesUser(UserEn u)
    	{
    	}

    	// Returns TRUE is the the validation of a user is correct, FALSE in other case
        public bool ValidationUser(string email, string password)
        {
        }


	 	// Returns a list with the recipes that a user have done
        public List<Recipe> RecipesUser(UserEN user)
        {
        }

        // Returns a list with the comments that a user have done
        public List<Comment> CommentsUser(UserEN user)
        {
        }

        // Returns a list of the users that has equals or more puntation that the given by parameter
        public List<User> PuntuationUser(int puntuacion)
        {
        }

        // Returns TRUE if the email is already use, FALSE in other case
        public bool CheckEmail(string email)
        {
        }

        // Returns TRUE if the nick is already in use, FALSE in other case
        public bool CheckNick(string nick)
        {
        }

        public void voteRecipe(User user, Recipe recipe, int vote)
        {

        }

        public void comment(User user, Comment comment)
        {

        }



    	/***********/
        /** DATOS **/
        /***********/

        private Database db;
        private UserEn user;
        private ArrayList<UserEN> users;
    }

 }
