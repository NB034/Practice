using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Strategy
{
    internal class BlowUpStrategy : IDestroyStrategy
    {
        public void Destroy(Object3D obj)
        {
            // Blow up object
        }
    }
}
