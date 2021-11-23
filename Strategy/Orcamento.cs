using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy {
    public class Orcamento {
        public double Valor { get; set; }
        public List<string> Itens { get; set; } = new List<string>();

        public Orcamento(double valor) {
            Valor = valor;
        }
    }
}
