using Generics;
using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { ISBN = "PAZ123", Name = "Moby Dick" };
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            Console.ReadLine();
        }
    }
}

namespace Generics
{
    // five types of constraints:
    // where T : IComparable (as applying T to an interface (eg IComparable here)
    // where T : Product (apply to a class (eg class Product here); this says T is a Product or any of it's children)
    // where T : struct (T should be value type)
    // where T : class (T has to be reference type)
    // where T : new() (T is an object that has a default constructor)
    
    // example of a struct constraint (note .Net framework already has a generic Nullable type
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);  // every reference or value type has a default value(ie null, 0, False, etc.) this returns the default of passed type
        }
    }

    // example of a class constraint
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(Product product)
        {
            return product.Price * (float)0.90; 
        }
    }

    // example of a new() constraint
    public class DoSomething<T> where T : IComparable, new() // T must have a default constructor
    {
        public void DoTheThing(T value)
        {
            var obj = new T(); // compiler doesn't know what type T is referring to (all it knows is T should implement IComparable interface)
            // have to apply second constraint, add new() to make T have a default constructor; now this works
        }
    }
}
