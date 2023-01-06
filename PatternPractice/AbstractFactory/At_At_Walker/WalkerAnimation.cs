using ClassWork.PatternPractice.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.At_At_Walker
{
    internal class WalkerAnimation : IAnimation
    {
        public Object3dTypes Type => Object3dTypes.At_At_Walker;

        public void Move()
        {
            // Walk
        }
    }
}
