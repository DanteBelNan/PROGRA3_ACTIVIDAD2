using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

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
            MarcaDB marcaDB = new MarcaDB();
            CategoriaDB categoriaDB = new CategoriaDB();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Articulo articulo = new Articulo();
                    articulo.id = lector.GetInt32(0);
                    
                    articulo.codigo = (string)lector["Codigo"];
                    articulo.nombre = (string)lector["Nombre"];
                    articulo.descripcion = (string)lector["Descripcion"];
                    int idMarca = (int)lector["IdMarca"];
                    articulo.Marca = marcaDB.obtener(idMarca);
                    int idCategoria = (int)lector["IdCategoria"];
                    articulo.Categoria = categoriaDB.obtener(idCategoria);
                    articulo.precio = (decimal)lector["Precio"];
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

        public void agregar(string codigo, string nombre, string descripcion, int idmarca, int idcategoria, decimal precio)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[ARTICULOS] ([Codigo], [Nombre], [Descripcion], [IdMarca], [IdCategoria], [Precio])" +
                "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)";
                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@IdMarca", idmarca);
                comando.Parameters.AddWithValue("@IdCategoria", idcategoria);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Connection = conexion;
                conexion.Open();
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Articulo creado");
                }
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
                    articulo.Marca = marcaDB.obtener(idMarca);
                    int idCategoria = (int)reader["IdCategoria"];
                    articulo.Categoria = categoriaDB.obtener(idCategoria);
                    articulo.precio = (decimal)reader["Precio"];
                    MessageBox.Show("Articulo cargado");
                    return articulo;
                }
                else
                {
                    MessageBox.Show("Articulo no encontrado");
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
                    MessageBox.Show("Articulo modificado");
                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo con el ID proporcionado.");
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
