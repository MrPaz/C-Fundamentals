using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle DB Connection Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle DB Connection Closed");
        }
    }
}
