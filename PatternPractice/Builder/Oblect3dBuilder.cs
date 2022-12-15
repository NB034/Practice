using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Builder
{
    internal class Oblect3dBuilder
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Oblect3dBuilder(string name, int? x, int? y, int? z = null)
        {
            Name = name;
            X = x.Value;
            Y = y.Value;
            Z = z.Value;
        }

        public void SetName(string name) => Name = name;
        public void SetX(int x) => X = x;
        public void SetY(int y) => Y = y;
        public void SetZ(int z) => Z = z;

        public Object3D Build()
        {
            return new Object3D(Name, X, Y, Z);
        }
    }
}
