using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL DB Connection Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL DB Connection Closed");
        }
    }
}
