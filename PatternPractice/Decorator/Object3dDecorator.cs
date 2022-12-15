using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Decorator
{
    internal class Object3dDecorator
    {
        private Object3D object3D;

        public Object3dDecorator(Object3D obj) 
        { 
            object3D = obj;
        }

        public void ChangeX(int x)
        {
            object3D.ObjectLocation = new Location(x, object3D.ObjectLocation.Y, object3D.ObjectLocation.Z);
        }

        public void ChangeY(int y)
        {
            object3D.ObjectLocation = new Location(object3D.ObjectLocation.X, y, object3D.ObjectLocation.Z);
        }

        public void ChangeZ(int z)
        {
            object3D.ObjectLocation = new Location(object3D.ObjectLocation.X, object3D.ObjectLocation.Y, z);
        }
    }
}
