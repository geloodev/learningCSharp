using System;

namespace matrizes {

    internal class Program {

        static void Main(string[] args) {

            //cria uma matriz retangular
            int[,] itens = new int[4,6]; // new int [linha, coluna]

            itens[2,3] = 99;
            itens[2,2] = itens[2,3];
            itens[2,3]++;

            Console.Write("\nitens[4, 6] =\n");
            
            //GetLength() acessa o tamanho das linhas (0) e colunas (1)
            for (int row = 0; row < itens.GetLength(0); row++) { 
                
                for (int col = 0; col < itens.GetLength(1); col++) {

                    Console.Write("\t{0}", itens[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}