using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Prototype
{
    internal class Object3D : IObject3D, ICloneable
    {
        public string Name { get; set; }
        public Location ObjectLocation { get; set; }

        public Object3D(string name, int x, int y, int z)
        {
            Name = name;
            ObjectLocation = new Location(x, y, z);
        }

        public object Clone()
        {
            return (object)new Object3D(Name, ObjectLocation.X, ObjectLocation.Y, ObjectLocation.Z);
        }

        public void PrepareForRender()
        {
            // Logic
        }
    }
}
