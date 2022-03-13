using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01 {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria c1 = new ContaBancaria();

            // c1.deposito(20);
            c1.saque(20);

            Console.WriteLine("Mensagem: {0}", c1.mensagemErro());
            Console.WriteLine("Saldo: {0:C}", c1.saldo());
        }
    }
}
