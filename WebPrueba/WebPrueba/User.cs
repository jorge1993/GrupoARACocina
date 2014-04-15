using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class User
    {
        private string email;
        private string name;
        private string surname;
        private string country;
        private int age;
        private string nick;
        private string password;

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
    }
}