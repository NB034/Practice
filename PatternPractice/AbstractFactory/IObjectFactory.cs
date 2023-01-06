using ClassWork.PatternPractice.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory
{
    internal interface IObjectFactory
    {
        void LoadObject();
        void LoadAnimation();
        void LoadPhysics();
    }
}
