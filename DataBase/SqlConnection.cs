using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class SqlConnection : DbConnection
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public SqlConnection(string connectionString) : base (connectionString)
        {
        }
        public override void OpenConnection()
        {
            StartTime = DateTime.Now;
            Console.WriteLine("Connection Openned sql");
        }
        public override void CloseConnection()
        {
            EndTime = DateTime.Now.AddDays(1).AddHours(5);
            Console.WriteLine("Connection Closed sql");
            Timeout = EndTime - StartTime;
        }
    }
}
