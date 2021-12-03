using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    class Reprovado : EstadoDeUmOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            throw new Exception("Não é possível aplicar desconto em um orcamento reprovado");
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Não é possível aprovar um orcamento já reprovado");
        }

        public void Finaliza(Orcamento orcamento) {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Não é possível reprovar um orcamento já reprovado");
        }
    }
}
