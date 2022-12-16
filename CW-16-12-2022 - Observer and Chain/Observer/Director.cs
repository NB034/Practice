using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Observer
{
    internal class Director : IObserver
    {
        public void ReactOnChanges(ICustomObservable observable, string property)
        {
            var employee = observable as Employee;
            if(observable != null)
            {
                Console.WriteLine
                    ($"The employee is {(employee.IsWorking ? "" : "not")} working on {employee.WorkingOnWhat}");
            }
        }
    }
}
