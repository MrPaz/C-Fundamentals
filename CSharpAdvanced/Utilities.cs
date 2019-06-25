using System;

namespace Generics
{
    public class Utilities // could also add constraint at class level, ie public class Utilitites<T> where T : IComparable, and get rid of constraint at method level
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable // add constraint which says "where T is an IComparable"
        {
            //return a > b ? a : b; // compiler thinks a and b are objects here, doesn't work; 
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
