using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator {
    public class Orcamento {
        public double Valor { get; set; }

        public Orcamento(double valor) {
            Valor = valor;
        }
    }
}
