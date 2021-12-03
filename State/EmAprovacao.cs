using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    class EmAprovacao : EstadoDeUmOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento) {
            orcamento.Estado = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento) {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento) {
            orcamento.Estado = new Reprovado();
        }
    }
}
