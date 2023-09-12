using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Actividad2
{
    internal class ArticuloDB
    {
        public List <Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Articulo articulo = new Articulo();
                    articulo.id = (int)lector["Id"];
                    articulo.codigo = (string)lector["Codigo"];
                    articulo.nombre = (string)lector["Nombre"];
                    articulo.descripcion = (string)lector["Descripcion"];
                    articulo.idMarca = (int)lector["IdMarca"];
                    articulo.idCategoria = (int)lector["IdCategoria"];
                    articulo.precio = (float)lector["Precio"];

                    lista.Add(articulo);

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
