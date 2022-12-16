using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ChainOfResponsibility
{
    internal class UsersDataBase : IHandler
    {
        public bool SearchUser(string login, string password) => Search(login, password);

        private bool Search(string login, string password)
        {
            Dictionary<string, string> map = new Dictionary<string, string>{
                {"A", "1"},
                {"B", "2"},
                {"C", "3"},
            };
            foreach(var key in map)
            {
                if (key.Key == login && key.Value == password) return true;
            }
            return false;
        }
    }
}
