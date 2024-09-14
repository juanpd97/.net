using Microsoft.Data.SqlClient;
using model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

    }
}
