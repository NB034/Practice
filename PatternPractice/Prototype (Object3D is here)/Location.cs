using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Prototype
{
    internal class Location
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
