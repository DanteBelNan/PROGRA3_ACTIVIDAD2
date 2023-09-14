using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class RolDB
    {
        public string obtener(int id)
        {
            string rolName;
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[ROLES] WHERE id_rol = @rolID";
                cmd.Parameters.AddWithValue("@rolID", id);
                cmd.Connection = connection;

                connection.Open();
                reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    
                    rolName = (string)reader["nombre"];
                }
                else
                {
                    throw new Exception("User not found...");
                }

                return rolName;
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
    }
}
