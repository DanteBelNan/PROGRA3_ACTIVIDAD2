using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using dominio;

namespace negocio
{
    public class ArticuloDB
    {
        public List <Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id =A.IdMarca and C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.id = (int)datos.Lector["Id"];
                    articulo.codigo = (string)datos.Lector["Codigo"];
                    articulo.nombre = (string)datos.Lector["Nombre"];
                    articulo.descripcion = (string)datos.Lector["Descripcion"];
                    articulo.marca = new Marca();
                    articulo.marca.Descripcion = (string)datos.Lector["Marca"];;
                    articulo.categoria = new Categoria();
                    articulo.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.precio = (decimal)datos.Lector["Precio"];
                    lista.Add(articulo);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
             finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) values ('" + nuevo.codigo + "','" + nuevo.nombre + "','" + nuevo.descripcion + "','" + nuevo.precio + "', @idMarca, @idCategoria)");
                datos.setearParametro("@idMarca", nuevo.marca.Id);
                datos.setearParametro("@idCategoria", nuevo.categoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public Articulo obtener(string codigo)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[ARTICULOS] WHERE Codigo = @Codigo";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();
                Articulo articulo;
                if (reader.Read())
                {
                    articulo = new Articulo();
                    articulo.id = (int)reader["Id"];
                    articulo.nombre = (string)reader["Nombre"];
                    articulo.descripcion = (string)reader["Descripcion"];
                    int idMarca = (int)reader["IdMarca"];
                    articulo.marca.Descripcion = (string)reader["Descripcion"];
                    int idCategoria = (int)reader["IdCategoria"];
                    articulo.categoria.Descripcion = (string)reader["Descripcion"];
                    articulo.precio = (decimal)reader["Precio"];
                    //MessageBox.Show("Articulo cargado");
                    return articulo;
                }
                else
                {
                    //MessageBox.Show("Articulo no encontrado");
                    return articulo = null;
                }

            }
            catch (Exception ex)
            {
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

        public void modificar(int id, string nuevoCodigo, string nuevoNombre, string nuevaDescripcion, int nuevoIdMarca, int nuevoIdCategoria, decimal nuevoPrecio)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE [dbo].[ARTICULOS] " +
                    "SET [Codigo] = @NuevoCodigo, [Nombre] = @NuevoNombre, [Descripcion] = @NuevaDescripcion, [IdMarca] = @NuevoIdMarca, [IdCategoria] = @NuevoIdCategoria, [Precio] = @NuevoPrecio " +
                    "WHERE [Id] = @Id";

                comando.Parameters.AddWithValue("@NuevoCodigo", nuevoCodigo);
                comando.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                comando.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion);
                comando.Parameters.AddWithValue("@NuevoIdMarca", nuevoIdMarca);
                comando.Parameters.AddWithValue("@NuevoIdCategoria", nuevoIdCategoria);
                comando.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                comando.Parameters.AddWithValue("@Id", id);

                comando.Connection = conexion;
                conexion.Open();
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Articulo modificado");
                }
                else
                {
                   // MessageBox.Show("No se encontró ningún artículo con el ID proporcionado.");
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
