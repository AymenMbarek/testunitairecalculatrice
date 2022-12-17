using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
   public   class CalculAvances
    {
        Authentication authentication;
        Double number;
        

        public CalculAvances(double x, Authentication authentication)
        {
            this.authentication = authentication;
        }
        public CalculAvances(double x, Authentication authentication , )
        {
            this.authentication = authentication;
        }
        public CalculAvances()
        {

        }
        public double ValeurAbsolue(Double x , User user)
        {
            if (authentication.Auth(user))
            {
                Double y = Math.Abs(x);
                return y;

            }
            else throw new AuthenticationException("  Vous n'avez pas l'accées a cette calculatrice ! ");
        }
    }
}
