using System;

namespace Generics
{
    public class ObjectList
    {
        public void Add(object value)
        {
            // add object
        }

        public object this[int index] // more general but performance penalty because every value has to be boxed and unboxed
        {
            get { throw new NotImplementedException(); }
        }
    }
}
