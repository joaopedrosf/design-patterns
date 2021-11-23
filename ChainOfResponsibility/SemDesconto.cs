using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility {
    public class SemDesconto : Desconto {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento) {
            return 0;
        }
    }
}
