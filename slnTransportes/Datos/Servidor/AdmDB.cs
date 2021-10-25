using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Datos.Servidor
{
   internal static class AdmDB
    {
        internal static SqlConnection ConectarBase()
        {
            string connectionString = Datos.Properties.Settings.Default.KeyDbTransporte;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
