using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_GPT.Models
{
    public class Database
    {
        private readonly string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=prueba;Data Source=jp-omen";

        public Database()
        {
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }   
            
    }
}
