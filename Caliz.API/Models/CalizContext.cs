using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caliz.API.Models
{
    public class CalizContext
    {
        public string ConnectionString { get; set; }

        public CalizContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
