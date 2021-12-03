using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    class Aprovado : EstadoDeUmOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Não é possível aprovar um orcamento já aprovado");
        }

        public void Finaliza(Orcamento orcamento) {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Não é possível reprovar um orcamento já aprovado");
        }
    }
}
