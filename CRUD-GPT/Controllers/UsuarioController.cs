using CRUD_GPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_GPT.Controllers
{
    public class UsuarioController
    {

        private readonly Database db;
        public UsuarioController()
        {
        db = new Database(); 
        }
    
        public void crearUsuario(Usuario usuario)
        {

            using (SqlConnection connection = db.GetSqlConnection())
            {
                string query = "INSERT INTO Usuario (Nombre, Apellido, Edad, id) VALUES (@Nombre, @Apellido, @Edad, @id)";

                using (SqlCommand comando = new SqlCommand())
                {
                    comando.CommandText = query;
                    comando.Connection = connection;
                    comando.Parameters.AddWithValue("@nombre", usuario.nombre);
                    comando.Parameters.AddWithValue("@apellido", usuario.apellido);
                    comando.Parameters.AddWithValue("@edad", Convert.ToInt32(usuario.edad));
                    comando.Parameters.AddWithValue("@id", Convert.ToInt32(usuario.id));

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("error: " + ex.Message);
                    }
                }
            
            }


        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conexion = db.GetSqlConnection() )
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "select id,nombre,apellido,edad from Usuario";
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.edad = (int)(reader["edad"]);
                                usuario.nombre = (string)reader["nombre"];
                                usuario.apellido = (string)reader["apellido"];
                                //usuario.id = (int)reader["id"];
                                usuario.id = Convert.ToInt32(reader["id"]);

                                usuarios.Add(usuario);
                            }
                            return usuarios;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


                return new List<Usuario>(); 
        }
    
        public DataTable ObtenerUsuarioPorId(int id)
        {
            using (SqlConnection conexion = db.GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "Select id,nombre,apellido,edad from Usuario where id = @id";
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@id", id);

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("id", typeof(int));
                            dataTable.Columns.Add("nombre", typeof(string));
                            dataTable.Columns.Add("apellido", typeof(string));
                            dataTable.Columns.Add("edad", typeof(int));

                            if (reader.Read())
                            {
                                DataRow row = dataTable.NewRow();
                                row["id"] = (int)reader["id"];
                                row["nombre"] = (string)reader["nombre"];
                                row["apellido"] = (string)reader["apellido"];
                                row["edad"] = (int)reader["edad"];

                                dataTable.Rows.Add(row);
                            }


                            return dataTable;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("error: " + ex);
                            return null;
                        }
                    }
                       
                }
            }
        }
    
        public void eliminarUsuario(int id)
        {
            using (SqlConnection conexion = db.GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "delete from Usuario where id = @id";
                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@id", id);

                    conexion.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex);
                    }
                }
            };

        }
    
        public void editarUsuario(int id,string nombre,string apellido,int edad)
        {
            using (SqlConnection conexion = db.GetSqlConnection()) 
            {
                using (SqlCommand cmd = new SqlCommand()) {
                    string query = "UPDATE Usuario SET nombre = @nombre, apellido = @apellido, edad = @edad WHERE id = @id";

                    cmd.CommandText = query;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@edad", edad);
                    cmd.Parameters.AddWithValue("@id", id);

                    

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("error:" + ex);
                    }

                }
            }
        }
    }
}
