using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    class Finalizado : EstadoDeUmOrcamento {
        public void AplicaDesconto(Orcamento orcamento) {
            throw new Exception("Não é possível aplicar desconto em um orcamento finalizado");
        }

        public void Aprova(Orcamento orcamento) {
            throw new Exception("Não é possível aprovar um orcamento finalizado");
        }

        public void Finaliza(Orcamento orcamento) {
            throw new Exception("Não é possível finalizar um orcamento já finalizado");
        }

        public void Reprova(Orcamento orcamento) {
            throw new Exception("Não é possível reprovar um orcamento já finalizado");
        }
    }
}
