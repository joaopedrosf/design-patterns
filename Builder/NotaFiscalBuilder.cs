using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    class NotaFiscalBuilder {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; } = 0;
        public double Impostos { get; private set; }
        public IList<Item> Itens { get; private set; } = new List<Item>();
        public string Observacoes { get; private set; }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial) {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder comCnpj(string cnpj) {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual() {
            DataDeEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(Item item) {
            Itens.Add(item);
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes) {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscal Build() {
            foreach (var item in Itens) {
                ValorBruto += item.Valor;
            }

            Impostos = ValorBruto * 0.05;

            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
    }
}
