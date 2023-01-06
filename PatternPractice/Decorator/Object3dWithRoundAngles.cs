using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Decorator
{
    internal class Object3dWithRoundAngles : IObject3D
    {
        private IObject3D object3D;

        public int RoundnessOfAngles { get; set; }

        public Object3dWithRoundAngles(Object3D obj) => object3D = obj;

        public void PrepareForRender()
        {
            ResetRoundness();
            object3D.PrepareForRender();
        }

        private void ResetRoundness() => RoundnessOfAngles = 0;
    }
}
