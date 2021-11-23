using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy {
    class CalculadorDeImpostos {
        public static void RealizaCalculo(Orcamento orcamento, Imposto imposto) {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine("Valor do imposto: R$" + valor);
        }
    }
}
