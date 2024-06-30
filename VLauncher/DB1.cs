using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VilmLauncher
{
    internal class DB1
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data source=Data Source=SLAVIKPC1\VILMSQLBASE;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public void sqlOpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void sqlCloseConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetSqlConnection() { return sqlConnection; }
    }
}
