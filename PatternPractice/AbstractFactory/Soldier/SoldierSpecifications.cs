using ClassWork.PatternPractice.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.AbstractFactory.Soldier
{
    internal class SoldierSpecifications : IPhysical
    {
        public Object3dTypes Type => Object3dTypes.Soldier;

        public int Weight { get; set; }
    }
}
