using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models;
using System.Data;
using System.Data.SqlClient;
using Datos.Servidor;

namespace Datos.Admin
{
    public static class AdmAuto
    {
        public static List<Auto> Listar()
        {
            //TODO falta iplementar Listar()
            string querySQL = "SELECT Id,Marca,Modelo,Matricula,Precio FROM dbo.Auto";

            SqlCommand command = new SqlCommand(querySQL, AdmDB.ConectarBase());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Auto> autos = new List<Auto>();

            while (reader.Read())
            {
                autos.Add(
                    new Auto()
                    {
                        Id = (int) reader["Id"],
                        Marca= reader["Marca"].ToString(),
                        Modelo= reader["Modelo"].ToString(),
                        Matricula= reader["Matricula"].ToString(),
                        Precio= Convert.ToDecimal(reader["Precio"])
                    });
            }

            reader.Close();

            AdmDB.ConectarBase().Close();

            return autos;
        }

        public static DataTable Listar(string marca)
        {

            string querySql = "SELECT Id,Marca,Modelo,Matricula,Precio FROM dbo.Auto WHERE Marca = @Marca";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdmDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Marca", SqlDbType.VarChar,50).Value = marca;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Marca");

            return ds.Tables["Marca"];
        }

        public static DataTable ListarMarcas()
        {

            string querySql = "SELECT distinct Marca FROM dbo.Auto ";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdmDB.ConectarBase());


            DataSet ds = new DataSet();

            adapter.Fill(ds, "Marca");

            return ds.Tables["Marca"];
        }

        public static int Insertar(Auto auto)
        {
            //TODO falta iplementar Insertar(auto)
            string querySQL = "INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES (@Marca,@Modelo,@Matricula,@Precio)";

            SqlCommand command = new SqlCommand(querySQL, AdmDB.ConectarBase());

            command.Parameters.Add("@Marca", SqlDbType.VarChar, 50).Value = auto.Marca;

            command.Parameters.Add("@Modelo", SqlDbType.VarChar, 50).Value = auto.Modelo;

            command.Parameters.Add("@Matricula", SqlDbType.Char,6).Value = auto.Matricula;

            command.Parameters.Add("@Precio", SqlDbType.Int).Value = auto.Precio;

            int filasAfectadas = command.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();

            return filasAfectadas;
        }

        public static int Modificar(Auto auto)
        {
            //TODO falta iplementar Modificar(auto)
            string querySQL = "UPDATE dbo.Auto SET Marca=@Marca, Modelo=@Modelo, Matricula = @Matricula, Precio = @Precio WHERE Id=@Id";

            SqlCommand command = new SqlCommand(querySQL, AdmDB.ConectarBase());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = auto.Id;

            command.Parameters.Add("@Marca", SqlDbType.VarChar, 50).Value = auto.Marca;

            command.Parameters.Add("@Modelo", SqlDbType.VarChar, 50).Value = auto.Modelo;

            command.Parameters.Add("@Matricula", SqlDbType.Char,6).Value = auto.Matricula;

            command.Parameters.Add("@Precio", SqlDbType.Int).Value = auto.Precio;

            int filasAfectadas = command.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();

            return filasAfectadas;

        }

        public static int Eliminar(int id)
        {
            //TODO falta iplementar Eliminar(id)
            string querySQL = "DELETE FROM Auto where Id=@ID";

            SqlCommand command = new SqlCommand(querySQL, AdmDB.ConectarBase());

            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

            int filasAfectadas = command.ExecuteNonQuery();

            AdmDB.ConectarBase().Close();

            return filasAfectadas;
        }
    }
}
