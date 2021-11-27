using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator {
    class ICMS : Imposto {

        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() { }

        public override double Calcula(Orcamento orcamento) {
            return 0.10 * orcamento.Valor + CalculoDoOutroImposto(orcamento);
        }
    }
}
