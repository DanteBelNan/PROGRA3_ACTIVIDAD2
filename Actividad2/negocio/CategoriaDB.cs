using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    internal class CategoriaDB
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from CATEGORIAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)lector["Id"];
                    categoria.Descripcion = (string)lector["Descripcion"];
                    lista.Add(categoria);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string obtener(int id)
        {
            string categoriaName;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[CATEGORIAS] WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoriaName = (string)reader["Descripcion"];
                }
                else
                {
                    categoriaName = "N/A";
                }

                return categoriaName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                connection.Close();
            }
        }

        public int obtener(string desc)
        {
            int categoriaID;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[CATEGORIAS] WHERE Descripcion = @desc";
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoriaID = (int)reader["Id"];
                }
                else
                {
                    categoriaID = 0;
                }

                return categoriaID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                connection.Close();
            }
        }
    }
}
