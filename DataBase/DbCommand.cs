using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class DbCommand 
    {
        
        public DbCommand(DbConnection connection)
        {
            if (connection == null)
                throw new InvalidCastException();
        }
        public string Instruction()
        {
            return $"Intructiuni";
        }
        public void Execute()
        {            
            //DbConnection.OpenConnection();
            //Console.WriteLine(Instruction());
            //DbConnection.CloseConnection();
        }

       
    }
}
