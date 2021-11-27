using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator {
    public class DecoratorMain {
        public static void MainDecorator() {
            Imposto impostos = new ISS(new ICMS());
            Orcamento orcamento = new Orcamento(1000);

            double valorImposto = impostos.Calcula(orcamento);

            Console.WriteLine("Valor de imposto pago para orcamento de R$1000 (ISS + ICMS) = R$" + valorImposto);
        }
    }
}
