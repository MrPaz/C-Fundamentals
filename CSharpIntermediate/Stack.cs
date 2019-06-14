using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Stack
    {
        private readonly List<object> _list;

        public Stack()
        {
            _list = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object cannot be null.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var index = _list.Count - 1;

            var pop = _list[index];

            _list.RemoveAt(index);

            return pop;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
