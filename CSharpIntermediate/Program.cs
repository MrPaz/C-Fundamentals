using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = Person.Parse("John"); // note: static method is called on the class, not on an instance of the class
            //person.Introduce("Matt");

            //var customer = new Customer();
            //customer.Id = 1;
            //customer.Name = "John";

            //var order = new Order();
            //customer.Orders.Add(order);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            //UseParams();

            //var person = new Person(new DateTime(1982, 7, 1));
            //Console.WriteLine(person.Age);

            //var cookie = new HttpCookie();
            //cookie["name"] = "Matt";
            //Console.WriteLine(cookie["name"]);

            //var stopWatch = new Stopwatch();
            //stopWatch.Start();
            //stopWatch.Stop();

            //string title = "C# is a good language to learn";
            //string description = "C# and Microsoft's extensive .NET Framework allows you to build great applications!";
            //var post = new Post(title, description);
            //post.UpVote();
            //post.UpVote();
            //post.DisplayPost(); // should have +2 votes
            //post.DownVote();
            //post.DownVote();
            //post.DownVote();
            //post.DisplayPost(); // should have -1 votes

            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            var connectionString = "domoarigotomrroboto";
            //var command = new DbCommand(new SqlConnection(connectionString), "Command in action");
            var command = new DbCommand(new OracleConnection(connectionString), "Command in action");
            command.Execute();

            Console.ReadLine();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4}));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60)); // takes the newLocation parameter; the new Point() is newLocation parameter 
                Console.WriteLine("Point is now at ({0}, {1}).", point.X, point.Y);

                point.Move(100, 200); // takes the two int parameters
                Console.WriteLine("Point is now at ({0}, {1}).", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }
        }
    }
}
