using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer {
    class EnviarEmail : NotaFiscalAction {
        public void Execute() {
            Console.WriteLine("Enviando email...");
        }
    }
}
