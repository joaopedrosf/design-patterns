using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility {
    class DescontoPorMaisDeQuinhentosReais : Desconto {
        public Desconto ProximoDesconto { get; set; } = new SemDesconto();

        public DescontoPorMaisDeQuinhentosReais(Desconto proximoDesconto) {
            ProximoDesconto = proximoDesconto;
        }
        public double Desconta(Orcamento orcamento) {
            if(orcamento.Valor >= 500) {
                return orcamento.Valor * 0.2;
            }
            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
