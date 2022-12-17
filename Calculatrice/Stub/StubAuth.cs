using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
  public   class StubAuth
    {
        public StubAuth()
        {

        }
        public bool Authentificate(User user)
        {
            if(user == null)
            {
                return false;
            }
            return true;
        }
    }
}
