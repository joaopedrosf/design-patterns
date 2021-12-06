using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    public class BuilderMain {

        public static void MainBuilder() {
            NotaFiscalBuilder nfBuilder = new NotaFiscalBuilder();
            NotaFiscal nf = nfBuilder.ComRazaoSocial("Razão Social")
                                     .comCnpj("Cnpj")
                                     .NaDataAtual()
                                     .ComItem(new Item("Item 1", 100))
                                     .ComItem(new Item("Item 2", 200))
                                     .ComObservacoes("Observações")
                                     .Build();
            
            Console.WriteLine(nf.ToString());
        }
    }
}
