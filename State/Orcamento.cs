using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    class Orcamento {
        public double Valor { get; set; }
        public EstadoDeUmOrcamento Estado { get; set; } = new EmAprovacao();

        public Orcamento(double valor) {
            Valor = valor;
        }

        public void AplicaDesconto() {
            Estado.AplicaDesconto(this);
        }

        public void Aprova() {
            Estado.Aprova(this);
        }

        public void Finaliza() {
            Estado.Finaliza(this);
        }

        public void Reprova() {
            Estado.Reprova(this);
        }
    }
}
