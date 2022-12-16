using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Observer
{
    internal interface IObserver
    {
        void ReactOnChanges(ICustomObservable observable, string property);
    }
}
