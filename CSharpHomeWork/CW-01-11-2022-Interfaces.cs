using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class RangeOfArray<T> : IEnumerable<T>
    {
        public RangeOfArray(int lowerBound, int upperBound)
        {
            if (upperBound < lowerBound)
                throw new CustomException("Upper bound cannot be less then lower bound.");
            LowerBound = lowerBound;
            UpperBound = upperBound;
            Array = new T[UpperBound - LowerBound];
        }

        public int LowerBound { get; private set; }
        public int UpperBound { get; private set; }
        public T[] Array { get; private set; }

        public T this[int index]
        {
            get { return Array[index - LowerBound]; }
            set { Array[index - LowerBound] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
