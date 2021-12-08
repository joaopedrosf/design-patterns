using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory {
    class SqlConnectionFactory {
        public static IDbConnection Make() {
            SqliteConnection conn = new SqliteConnection("Data Source=:memory:");
            return conn;
        }
    }
}
