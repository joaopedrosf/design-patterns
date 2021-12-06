using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer {
    public class ObserverMain {
        public static void MainObserver() {
            NotaFiscalBuilder nfBuilder = new NotaFiscalBuilder();
            nfBuilder.ComRazaoSocial("Razão Social")
                     .comCnpj("Cnpj")
                     .NaDataAtual()
                     .ComItem(new Item("Item 1", 100))
                     .ComItem(new Item("Item 2", 200))
                     .ComObservacoes("Observações");

            nfBuilder.AdicionarAcao(new EnviarEmail())
                     .AdicionarAcao(new SalvarNoBD())
                     .AdicionarAcao(new EnviarSms());

            NotaFiscal nf = nfBuilder.Build();

            Console.WriteLine(nf.ToString());
        }
    }
}
