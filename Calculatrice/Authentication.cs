using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculatrice
{
    public class Authentication : IAuthentication
    {
       public  DAOUser daouser;
        public Authentication(DAOUser daousrer)
        {
            this.daouser = daouser;
        }

        public bool Authentified => throw new NotImplementedException();

        public bool Auth( User user)
        {          
            return daouser.getUser(user);
        }

        public bool Authentifier(User user)
        {
            throw new NotImplementedException();
        }
    }
}
