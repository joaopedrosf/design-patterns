using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility {
    class ChainOfResponsibilityMain {
        public static void MainCOR() {
            Orcamento orcamento = new Orcamento(1000);
            orcamento.Itens.Add("Caneta");
            orcamento.Itens.Add("Lápis");
            orcamento.Itens.Add("Borracha");
            orcamento.Itens.Add("Apontador");

            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais(d1);

            var desconto = d2.Desconta(orcamento);
            Console.WriteLine("Desconto por mais de 500 reais: R$" + desconto);

            Orcamento orcamento2 = new Orcamento(100);
            orcamento2.Itens.Add("Caneta");
            orcamento2.Itens.Add("Lápis");
            orcamento2.Itens.Add("Borracha");
            orcamento2.Itens.Add("Apontador");
            orcamento2.Itens.Add("Caderno");
            orcamento2.Itens.Add("Lapiseira");

            var desconto2 = d2.Desconta(orcamento2);
            Console.WriteLine("Desconto por mais de 5 itens: R$" + desconto2);
        }
    }
}
