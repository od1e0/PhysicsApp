using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsApp.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server=localhost;Database=PhysicsAppDb;Trusted_Connection=True;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection( _connectionString ); 
        }
    }
}
