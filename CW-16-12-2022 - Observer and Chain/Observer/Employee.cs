using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Observer
{
    internal class Employee : ICustomObservable
    {
        public List<IObserver> observers { get; set; } = new List<IObserver>();

        public void Notify(string property)
        {
            foreach (var observer in observers)
            {
                observer.ReactOnChanges(this, property);
            }
        }

        bool _isWorking = true;
        public bool IsWorking
        {
            get { return _isWorking; }
            set
            {
                _isWorking = value;
                Notify(nameof(IsWorking));
            }
        }

        string _workingOnWhat = "Program";
        public string WorkingOnWhat
        {
            get { return _workingOnWhat; }
            set
            {
                _workingOnWhat = value;
                Notify(nameof(WorkingOnWhat));
            }
        }
    }
}
