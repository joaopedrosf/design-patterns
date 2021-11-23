using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy {
    public class StrategyMain {
        public static void MainStrategy() {
            Orcamento orcamento = new Orcamento(1000);
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            CalculadorDeImpostos.RealizaCalculo(orcamento, iss);
            CalculadorDeImpostos.RealizaCalculo(orcamento, icms);
        }
    }
}
