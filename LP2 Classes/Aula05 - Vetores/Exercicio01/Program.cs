using System;
using System.Linq;

namespace Program {

    internal class Program {

        static void Main(string[] args) {

        ApostaMegaSena aposta = new ApostaMegaSena();
        int[] sorteados = new int[6];
        var rand = new Random();

        //SORTEIO DOS NÚMEROS VENCEDORES
        for (int i = 0; i < sorteados.GetLength(0); i++) {
            
            bool repete = false;
            do {
                sorteados[i] = rand.Next(1, 61);
                if (sorteados.Contains(sorteados[1])) {
                    repete = false;
                }

            } while (repete == true);

        }

        //PERGUNTA AS APOSTAS, COMPARA E MOSTRA O RESULTADO
        aposta.leAposta();
        aposta.apuraResultado(sorteados);

        Console.Write("\nResultado do sorteio: \n");
        for (int i = 0; i < sorteados.GetLength(0); i++) {
            Console.Write("{0}  ", sorteados[i]);
        }
        Console.WriteLine();

        aposta.mostraResultado();

        }
    }
}