using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace model
{
    internal class ConnectionString
    {

        private readonly string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbPrueba-CRUD;Data Source=jp-omen; TrustServerCertificate=True;";
        
        public ConnectionString() { }
        public SqlConnection obtenerConexion()
        { 
            return new SqlConnection(connectionString);
        }
    
        
        

        
        

        }
    }

