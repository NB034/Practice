using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.TemplateMethod
{
    internal abstract class BaseObject3dLoader
    {
        public void LoadObject(Object3D object3D)
        {
            LoadTexture(object3D);
            Render(object3D);
        }

        public virtual void Render(Object3D object3D)
        {
            // Logic
        }

        public virtual void LoadTexture(Object3D object3D)
        {
            // Logic
        }
    }
}
