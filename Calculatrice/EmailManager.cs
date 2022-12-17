using Calculatrice.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Stub
{
    class EmailManager : IEmailManager
    {
        User user;
         
        public EmailManager(User user)
        {
            this.user = user;
        }
        public void SendMail(string subject, int result)
        {
            throw new NotImplementedException();
        }
    }
}
