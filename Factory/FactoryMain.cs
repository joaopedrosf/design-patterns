using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory {
    public class FactoryMain {
        public static void MainFactory() {
            var conn = SqlConnectionFactory.Make();
            Console.WriteLine("Conexão com banco de dados criada!");
            Console.WriteLine("Connection string: " + conn.ConnectionString);
        }
    }
}
