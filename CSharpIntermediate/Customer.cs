using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        //public readonly List<Order> Orders = new List<Order>(); // can also initialize empty list like so (then I can get rid of default constructor)
        // readonly modifier makes it so this field is assigned only once; cannot later be changed; 
        // this protects the field, improving robustness of code so it cannot be unintentionally modified

        public Customer() // constructor (default constructor initializes fields to null, zero, false, etc)
        {
            Orders = new List<Order>(); // best practices: when a class has a list field, always initialize it to an empty list
            // and always make sure containing class initializes the empty list (it's the class' responsiblity, not the class using this object)
        }

        public Customer(int id) // overloading allows flexibility when creating an instance of the class (say sometimes we have more data available
            : this() // calls default constructor before calling this constructor
        {
            this.Id = id;
        }

        public Customer(int id, string name) // than other times, we want to be able to create an instance and intitialize with whatever data we have)
            : this(id) // calls second constructor to handle id parameter (avoids repeating code; DRY)
        {
            this.Name = name;
        }
    }
}