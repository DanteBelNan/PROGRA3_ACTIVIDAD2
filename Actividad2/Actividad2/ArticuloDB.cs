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

    }
}
