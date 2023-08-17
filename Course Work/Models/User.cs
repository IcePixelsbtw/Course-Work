using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class User
    {
       
        public User()
        {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        
        }

        public User(string firstName, string lastName, string email, string password) 
        {
         FirstName = firstName;
         LastName = lastName;    
         Email = email;
         Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static string error;
        
        public static bool isEqual(User user1, User user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Email != user2.Email)
            {
                error = "Email does not exist";
                return false;
            } else if (user1.Password != user2.Password)
                {
                error = "Wrong password to that email";
                return false;   
                }
            return true;
        }
        

    }
}
