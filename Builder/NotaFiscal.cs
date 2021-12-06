using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    class NotaFiscal {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<Item> Itens { get; private set; }
        public string Observacoes { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<Item> itens,
                      string observacoes) {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }

        public override string ToString() {
            return "Razão Social: " + RazaoSocial + "\nCnpj: " + Cnpj + "\nData de Emissão: " + DataDeEmissao +
                "\nValor Bruto: R$" + ValorBruto + "\nImpostos: R$" + Impostos + "\nNúmero de itens: " + Itens.Count +
                "\nObservações: " + Observacoes;
        }
    }
}
