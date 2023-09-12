using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    internal class MarcaDB
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)lector["Id"];
                    marca.Descripcion = (string)lector["Descripcion"];
                    lista.Add(marca);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
