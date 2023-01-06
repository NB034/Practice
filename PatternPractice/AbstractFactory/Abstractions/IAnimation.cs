using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.Abstractions
{
    internal interface IAnimation
    {
        Object3dTypes Type { get; }
        void Move();
    }
}
