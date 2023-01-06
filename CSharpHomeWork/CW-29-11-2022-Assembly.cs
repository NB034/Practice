using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class CustomAssemblyInfoHandler
    {
        private Assembly assembly = null;

        public CustomAssemblyInfoHandler()
        {
            assembly = Assembly.GetExecutingAssembly();
            GetSomething();
        }

        private void GetSomething()
        {
            var attributes = assembly.CustomAttributes;
            foreach(var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }
        }
    }
}
