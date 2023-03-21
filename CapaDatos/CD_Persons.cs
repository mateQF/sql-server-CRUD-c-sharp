using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Persons
    {
        private CD_ConnectionDb connection = new();

        SqlDataReader reader;
        DataTable table = new();
        SqlCommand command = new SqlCommand();

        public DataTable GetPersons()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "ShowPersonas";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CloseConnection();
            return table;
        }

        public void InsertPerson(int dni, string nombre, string apellido, string domicilio, int telefono, int edad, string email) { 
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertPerson";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DNI", dni);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Domicilio", domicilio);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Edad", edad);
            command.Parameters.AddWithValue("@Email", email);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void UpdatePerson(int dni, string nombre, string apellido, string domicilio, int telefono, int edad, string email) {
            command.Connection = connection.OpenConnection();
            command.CommandText = "UpdatePerson";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DNI", dni);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Domicilio", domicilio);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Edad", edad);
            command.Parameters.AddWithValue("@Email", email);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void DeletePerson(int dni) {
            command.Connection = connection.OpenConnection();
            command.CommandText = "DeletePerson";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DNI", dni);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
