using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Logging;
using model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    internal class ClienteController
    {
        private readonly ConnectionString db;
        public ClienteController()
        {
            db = new ConnectionString();
        }

        public void agregarCliente(Cliente cliente)
        {
            using (SqlConnection conexion = db.obtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spInsertarCliente";
                    cmd.Connection = conexion;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.NVarChar, 15).Value = cliente.nombre;
                    cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.NVarChar, 50).Value = cliente.apellido;
                    cmd.Parameters.Add("@Edad", System.Data.SqlDbType.Decimal).Value = cliente.edad;
                    cmd.Parameters.Add("@DNI", System.Data.SqlDbType.NVarChar, 20).Value = cliente.dni;
                    cmd.Parameters.Add("@Telefono", System.Data.SqlDbType.BigInt).Value = cliente.telefono;
                    cmd.Parameters.Add("@FechaNacimiento",System.Data.SqlDbType.Date).Value = cliente.fechaNacimiento;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("God");
                        
                    }
                    catch (Exception ex) {
                        MessageBox.Show("error:" + ex);
                    }



                }

            }

        }

        public List<Cliente> mostrarTodosLosCLiente()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            using (SqlConnection conexion = db.obtenerConexion())
            { 
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spLeerClientes";
                    cmd.Connection = conexion;
                    
                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();

                                cliente.telefono = Convert.ToUInt64(reader["Telefono"]);
                                //cliente.telefono = (ulong)(reader["Telefono"]);
                                cliente.dni = (string)reader["DNI"];
                                cliente.nombre = (string)reader["Nombre"];
                                cliente.apellido = (string)reader["Apellido"];
                                cliente.fechaNacimiento = (DateTime)reader["FechaNacimiento"];

                                listaClientes.Add(cliente);
                            }
                        }
                        return listaClientes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return new List<Cliente>();
                    }



                }

            }
            return new List<Cliente>(); 
        }

        public DataTable buscarClientePorId(int id)
        {
            using (SqlConnection conexion = db.obtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spLeerClientePorId", conexion))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("id", typeof(int));
                    dataTable.Columns.Add("nombre", typeof(string));
                    dataTable.Columns.Add("apellido", typeof(string));
                    dataTable.Columns.Add("dni", typeof(string));
                    dataTable.Columns.Add("fecha_nacimiento", typeof(DateTime));
                    dataTable.Columns.Add("telefono", typeof(long));

                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DataRow row = dataTable.NewRow();
                                //row["id"] = reader.GetInt32(reader.GetOrdinal("id"));
                                row["id"] =Convert.ToInt32( reader["id"]);
                                row["nombre"] = reader["nombre"].ToString();
                                //row["apellido"] = reader.GetString(reader.GetOrdinal("apellido"));
                                row["apellido"] = reader["apellido"].ToString();
                                row["dni"] =  reader["dni"].ToString();
                                row["fecha_nacimiento"] = (DateTime)reader["fechaNacimiento"];
                                row["telefono"] = Convert.ToUInt64( reader["telefono"]);

                                dataTable.Rows.Add(row);
                                return dataTable;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro:" + ex.Message);
                    }

                    return null; 
                }
            }
        }
    
        public void eliminarClientePorId(int id)
        {
            using (SqlConnection conexion = db.obtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "spEliminarCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("cliente eliminado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error:" + ex.Message);
                    }

                }

            }
        }
    
        public void modificarCliente(int id,string nombre,string apellido,decimal edad,string dni,ulong telefono,DateTime fechaNacimiento)
        {
            using (SqlConnection conexion = db.obtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "spActualizarCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection  = conexion;
                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                    cmd.Parameters.Add("@Nombre",System.Data.SqlDbType.VarChar,15).Value = nombre;
                    cmd.Parameters.Add("@Apellido", System.Data.SqlDbType.VarChar,50).Value = apellido;
                    cmd.Parameters.Add("@DNI",System.Data.SqlDbType.VarChar,20).Value= dni;
                    cmd.Parameters.Add("@Telefono",System.Data.SqlDbType.BigInt).Value = telefono;
                    cmd.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.Date).Value = fechaNacimiento;

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Moidificacion exitosa");
                    } catch (SqlException ex){
                        MessageBox.Show("error:" + ex);
                            }
                }
            }
        }
    }
}
