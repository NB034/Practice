using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Strategy
{
    internal interface IDestroyStrategy
    {
        void Destroy(Object3D obj);
    }
}
