using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer {
    class SalvarNoBD : NotaFiscalAction {
        public void Execute() {
            Console.WriteLine("Salvando no BD...");
        }
    }
}
