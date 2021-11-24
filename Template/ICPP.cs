﻿using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template {
    public class ICPP : TemplateDeImpostoCondicional {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor >= 1000;
        }

        public override double MaximaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento) {
            return orcamento.Valor * 0.04;
        }
    }
}
