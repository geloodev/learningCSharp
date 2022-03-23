using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploContador {
    class Program {
        static void Main(string[] args) {
            
            Contador obj1 = new Contador();

            Contador obj2 = obj1; /* obj2 está fazendo a mesma função de obj1,
                                     referenciando o mesmo objeto. */

            //ambos obj1 e obj2 afetam o mesmo objeto Contador
            obj1.incrementa(5);
            obj2.imprime();

            obj2.incrementa(10);
            obj1.imprime();
            
        }
    }
}
