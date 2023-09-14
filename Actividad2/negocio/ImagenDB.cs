using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenDB
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();
            

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from IMAGENES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.id = lector.GetInt32(0);
                    imagen.idArticulo = lector.GetInt32(1);
                    imagen.imagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(imagen);

                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Imagen> listar(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from IMAGENES where IdArticulo = @idArticulo";
                comando.Parameters.AddWithValue("@idArticulo", idArticulo);
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.id = lector.GetInt32(0);
                    imagen.idArticulo = lector.GetInt32(1);
                    imagen.imagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(imagen);

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
