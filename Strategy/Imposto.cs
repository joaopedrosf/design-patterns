using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy {
    interface Imposto {
        public double Calcula(Orcamento orcamento);
    }
}
