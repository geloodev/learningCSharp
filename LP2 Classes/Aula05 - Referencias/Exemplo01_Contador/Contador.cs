using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContador {
    class Contador {
        private int valor;

        public Contador() {
            valor = 5;
        }

        public void incrementa(int incremento) {
            valor = valor + incremento;
        }

        public void imprime() {
            Console.WriteLine("valor: {0}", valor);

        }
    }
}
