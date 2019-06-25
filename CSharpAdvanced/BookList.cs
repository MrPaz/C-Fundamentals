using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            // add book logic
        }

        public Book this[int index] // problem is it's only for a list of books
        {
            get { throw new NotImplementedException(); }  
        }
    }
}
