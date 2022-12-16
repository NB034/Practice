using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ChainOfResponsibility
{
    internal interface IHandler
    {
        bool SearchUser(string login, string password);
    }
}
