using System;
using System.Linq;

namespace Program {

    internal class ApostaMegaSena {

        private int[] aposta = new int[6];
        private int acertos;

        public ApostaMegaSena() {

            acertos = 0;
            
            foreach (int i in aposta) {
                aposta[i] = 0;
            }

        }

        public void leAposta() {

            for (int i = 0; i < aposta.GetLength(0); i++) {

                do {

                    Console.Write("Digite o {0}º número (entre 1 e 60): ", i+1);
                    aposta[i] = Convert.ToInt32(Console.ReadLine());

                    if (aposta[i] < 1 || aposta[i] > 60) {
                        Console.WriteLine("\nNúmero inválido. Tente Novamente.");

                    }

                } while (aposta[i] < 1 || aposta[i] > 60) ;
            }
        }

        public void apuraResultado(int[] vetor) {
            
            for (int a = 0; a < aposta.GetLength(0); a++) {
                for (int v = 0; v < vetor.GetLength(0); v++) {
                    if (aposta[a] == vetor[v]) {
                        acertos++;
                    }
                }
            }
        }

        public void mostraResultado() {

            if (acertos == 6) {
                Console.WriteLine("Parabéns! Você ganhou o prêmio!");
            }
            else {
                Console.WriteLine("Infelizmente você não ganhou. Boa sorte na próxima!");
            }
        }
    }
}