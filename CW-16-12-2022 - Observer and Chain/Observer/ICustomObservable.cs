using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Observer
{
    internal interface ICustomObservable
    {
        List<IObserver> observers { get; set; }

        void Notify(string property);
    }
}
