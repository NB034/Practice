using ClassWork.PatternPractice.Prototype;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.PatternPractice.Iterator
{
    internal class Object3DCollection : IEnumerable<Object3D>
    {
        private List<Object3D> _objects = new List<Object3D>();

        public void Add(Object3D obj)
        {
            _objects.Add(obj);
        }

        public List<Object3D> AsList()
        {
            return _objects;
        }

        public IEnumerator<Object3D> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
