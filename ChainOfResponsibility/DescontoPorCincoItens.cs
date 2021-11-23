﻿using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility {
    class DescontoPorCincoItens : Desconto {
        public Desconto ProximoDesconto { get; set; } = new SemDesconto();

        public DescontoPorCincoItens(Desconto desconto) {
            ProximoDesconto = desconto;
        }

        public DescontoPorCincoItens() {

        }

        public double Desconta(Orcamento orcamento) {
            if(orcamento.Itens.Count > 5) {
                return orcamento.Valor * 0.1;
            }

            return ProximoDesconto.Desconta(orcamento);
        }
    }
}
