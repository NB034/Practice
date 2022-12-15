using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.Abstractions
{
    internal interface IPhysical
    {
        Object3dTypes Type { get; }

        int Weight { get; }
    }
}
