using System;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        DbConnection _dbConnection;
        string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("You must be connected to a database.");

            if (string.IsNullOrWhiteSpace(command))
                throw new InvalidOperationException("You must give a command.");

            _dbConnection = dbConnection;

            _command = command;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();

            Console.WriteLine("The following command was executed on the DB at connection string: " + _dbConnection.ConnectionString);
            Console.WriteLine("Command: " + _command);

            _dbConnection.CloseConnection();
        }
    }
}
