using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility {
    public interface Desconto {
        public Desconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento);
    }
}
