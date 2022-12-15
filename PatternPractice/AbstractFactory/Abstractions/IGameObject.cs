using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.Abstractions
{
    internal interface IGameObject
    {
        Object3dTypes Type { get; }

        void AddAnimation(IAnimation animation);
    }
}
