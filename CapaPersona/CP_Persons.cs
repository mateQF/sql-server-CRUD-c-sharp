using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaPersona
{
    public class CP_Persons
    {
        private CD_Persons objectCD = new();

        public DataTable ShowPersons()
        {
            DataTable table = new();
            table = objectCD.GetPersons();
            return table;
        }

        public void InsertPerson(string dni, string nombre, string apellido, string domicilio, string telefono, string edad, string email) {
            objectCD.InsertPerson(Convert.ToInt32(dni), nombre, apellido, domicilio, Convert.ToInt32(telefono), Convert.ToInt32(edad), email);
        }

        public void UpdatePerson(string dni, string nombre, string apellido, string domicilio, string telefono, string edad, string email) {
            objectCD.UpdatePerson(Convert.ToInt32(dni), nombre, apellido, domicilio, Convert.ToInt32(telefono), Convert.ToInt32(edad), email);
        }

        public void DeletePerson(string dni) {
            objectCD.DeletePerson(Convert.ToInt32(dni));
        }
    }
}
