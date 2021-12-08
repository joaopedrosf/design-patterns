using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight {
    class FlyweightMain {
        public static void MainFlyweight() {
            var musica = new List<INota>() {
                NotasMusicais.Get("do"),
                NotasMusicais.Get("re"),
                NotasMusicais.Get("mi"),
                NotasMusicais.Get("fa"),
                NotasMusicais.Get("fa"),
                NotasMusicais.Get("fa")
            };

            foreach (var nota in musica) {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
