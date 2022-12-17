using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class DAOUser
    {
       public List<User> users = new();
         public DAOUser()
        {
            users.Add((new User("Amira Baati", "passer" , "amirabaati@gmail.com")));
        }
        public bool getUser(User user)
        {
            return users.Contains(user);
        }
    }
}
