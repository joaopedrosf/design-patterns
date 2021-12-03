using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State {
    public class StateMain {
        public static void MainState() {
            try {
                Orcamento orcamento = new Orcamento(100);
                Console.WriteLine("Valor inicial do orcamento: R$" + orcamento.Valor);

                orcamento.AplicaDesconto();

                Console.WriteLine("Valor do orcamento com desconto de Em Aprovacao: R$" + orcamento.Valor);

                orcamento.Aprova();
                orcamento.AplicaDesconto();

                Console.WriteLine("Valor do orcamento com desconto de Aprovado: R$" + orcamento.Valor);

                orcamento.Reprova();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
