﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder {
    class Item {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double valor) {
            Nome = nome;
            Valor = valor;
        }
    }
}
