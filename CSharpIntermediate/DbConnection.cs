using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("A connection string is required.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
