using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class User
    {

        string login { get; set; }
        string password { get; set; }
        string  email { get; set;  }
        public User( string login , string password , string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;

        }
    }
}
