using System;

namespace Generics
{
    public class GenericList<T> // generics solve this problem, no performance penalty.  Parameter inside of <> brackets; T generally used--stands for Type
    {
        public void Add(T value) // takes type T, but T is not specified yet. Will be specified by user at instantiation
        {
            // add T logic
        }   

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
