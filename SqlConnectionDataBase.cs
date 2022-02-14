using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NewStore
{
    internal abstract class SqlConnectionDataBase
    {
        protected SqlConnection _connection;
        public SqlConnectionDataBase(string name)
        {
            _connection = new SqlConnection($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog={name}; Integrated Security=SSPI;");
        }
    }
}
