﻿using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template {
    public class IKCV : TemplateDeImpostoCondicional {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.06;
        }
    }
}
