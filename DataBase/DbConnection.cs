using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {            
            if(String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection can't be null or empty");
            }
            this.ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
