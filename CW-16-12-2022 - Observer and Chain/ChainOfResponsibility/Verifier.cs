using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ChainOfResponsibility
{
    internal class Verifier
    {
        List<IHandler> _handlers = new List<IHandler>();

        public void AddHandler(IHandler handler)
        {
            _handlers.Add(handler);
        }

        public void RemoveHandler(IHandler handler)
        {
            _handlers.Remove(handler);
        }

        public bool Verify(string login, string password)
        {
            foreach(IHandler handler in _handlers)
            {
                if (handler.SearchUser(login, password)) return true;
            }
            return false;
        }
    }
}
