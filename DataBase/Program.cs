using System;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new OracleConnection("as");
            sql.OpenConnection();
            sql.CloseConnection();
            Console.WriteLine(sql.Timeout);

            var command = new DbCommand(new SqlConnection("sa"));
            command.Execute();
            
        }
    }
}
