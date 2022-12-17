using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Interface
{
    interface IEmailManager
    {
        void SendMail(string subject, int result);
    }
}
