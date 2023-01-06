using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ChainOfResponsibility
{
    internal class UsersOldFileBase : IHandler
    {
        public bool SearchUser(string login, string password) => SearchInFiles(login, password);

        private bool SearchInFiles(string login, string password)
        {
            Dictionary<string, string> map = new Dictionary<string, string>{
                { "D", "4" },
                { "E", "5" },
                { "F", "6" },
            };
            foreach (var key in map)
            {
                if (key.Key == login && key.Value == password) return true;
            }
            return false;
        }
    }
}
