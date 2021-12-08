using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight {
    public class NotasMusicais {
        private static IDictionary<string, INota> notas = new Dictionary<string, INota>() {
            {"do", new Do() },
            {"re", new Re() },
            {"mi", new Mi() },
            {"fa", new Fa() },
            {"sol", new Sol() },
            {"la", new Fa() },
            {"si", new Si() }
        };

        public static INota Get(string nota) {
            return notas[nota];
        }
    }
}
