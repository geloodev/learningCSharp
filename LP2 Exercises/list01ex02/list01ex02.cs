/*
2. Crie um programa que peça para usuário digitar valores numérico positivo. Quando o usuário digitar um
valor negativo, o programa deve retornar a média dos valores numéricos entrados (excluindo o valor
negativo).
*/

using System;

namespace list01ex02 {

    internal class Program {

        static void Main(string[] args) {
            
            int soma = 0;
            int cont = 0;
            int num = 0;

            do {
                
                Console.Write("Digite um número positivo: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0) {
                    soma += num;
                    cont++;
                }

            } while (num >= 0);
            
            Console.WriteLine("A média dos números positivos é: {0}", soma/cont);

        }
    }
}