using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template {
    public class TemplateMain {
        public static void MainTemplate() {
            Orcamento orcamento = new Orcamento(500);
            Orcamento orcamento2 = new Orcamento(1000);

            Imposto ikcv = new IKCV();
            Imposto icpp = new ICPP();

            double taxacao1 = ikcv.Calcula(orcamento);
            double taxacao2 = icpp.Calcula(orcamento);
            double taxacao3 = icpp.Calcula(orcamento2);

            Console.WriteLine("IKCV, orcamento R$500 : " + taxacao1);
            Console.WriteLine("ICPP, orcamento R$500 : " + taxacao2);
            Console.WriteLine("ICPP, orcamento R$1000 : " + taxacao3);
        }
    }
}
