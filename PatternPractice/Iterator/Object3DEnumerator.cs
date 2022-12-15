using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Iterator
{
    internal class Object3DEnumerator : IEnumerator<Object3D>
    {
        Object3DCollection _objects;
        private int _index;

        public Object3DEnumerator(Object3DCollection objects)
        {
            _index = -1;
            _objects= objects;
        }

        public Object3D Current => _objects.AsList()[_index];

        object IEnumerator.Current => _objects.AsList()[_index] as object;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++_index < _objects.AsList().Count) return true;
            return false;
        }

        public void Reset()
        {
            _index= -1;
        }
    }
}
