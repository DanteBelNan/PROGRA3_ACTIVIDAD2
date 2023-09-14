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
    public class UsuarioDB
    {
        public Usuario obtener(string username)
        {
            Usuario usr = new Usuario();
            RolDB rolDB = new RolDB();
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[USUARIOS] WHERE username = @Username";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usr.id = reader.GetInt32(0);
                    usr.username = (string)reader["username"];
                    usr.password = (string)reader["password"];
                    int id_rol = reader.GetInt32(3);
                    usr.rol = rolDB.obtener(id_rol);
                }
                else
                {
                    throw new Exception("User not found...");
                }

                return usr;
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
    
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from [dbo].[USUARIOS]";
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usr = new Usuario();
                    usr.id = reader.GetInt32(0);
                    usr.username = (string)reader["username"];
                    usr.password = (string)reader["password"];

                    lista.Add(usr);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { connection.Close(); }
        }

        public bool Agregar(string username, string password)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into [dbo].[USUARIOS] values ('" + username + "', '" + password + "', 2)";
                cmd.Connection = connection;
                connection.Open();
                reader = cmd.ExecuteReader();
                return true;
            }
            catch(Exception ex) {
                return false;
            }
            finally { connection.Close(); }
        }
    }
}
