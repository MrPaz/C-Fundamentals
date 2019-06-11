
using System;

namespace CSharpIntermediate
{
    class Person
    {
        public string Name;
        //private DateTime _birthdate; // _ prefix is convention to denote private fields; not needed when you use auto prop

        //public DateTime GetBirthdate() // we use these get and set methods to modify the private fields; 
        //// these two get/set methods are for demonstration purposes only (in real world we use properties)
        //{
        //    return _birthdate;
        //}

        //public void SetBirthdate(DateTime birthdate) // the idea is to hide (encapsulate) implementation details when using a class object outside of the class
        //// which means only allowing other code to access the behaviors or actions (methods) of this class instance, not the data (fields)
        //{
        //    _birthdate = birthdate;
        //}
        //// equivalent property:
        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //}
        // auto property (don't need to explicitly define _birthdate, this will automatically generate a private field Birthdate internally)
        public DateTime Birthdate { get; private set; } // private makes setting the Birthdate field inaccessible outside this class

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}", to, Name);
        }

        //public static Person Parse(string str) // static method allows us to call this method without having an instance of the class
        //{
        //    var person = new Person();
        //    person.Name = str;

        //    return person;
        //}
    }
}
