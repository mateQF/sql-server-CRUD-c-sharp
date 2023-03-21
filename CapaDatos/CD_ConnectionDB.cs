using System;
using System.Net;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_ConnectionDb
    {
        private SqlConnection connection = new("Data Source=DESKTOP-L2NRV8G;Initial Catalog=testPersonas;User ID=fortuna;Password=a123456789;TrustServerCertificate=True");
        
        public SqlConnection GetConnection()
        {
            return connection;
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            Console.WriteLine("hola");
            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
