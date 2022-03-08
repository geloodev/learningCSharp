/*
1. Crie um programa que quando o usuário digitar um valor inteiro positivo “n”, retorne a soma dos “n”
primeiros números. Por exemplo se o usuário digitar “5” o programa deve retornar “15” pois “1 + 2 + 3 +
4 + 5 = 15”.
*/

using System;

namespace list01ex01 {
    
    internal class Program {

         static void Main(string[] args) {

             Console.Write("Digite um número inteiro: ");
             
             //converte INT para STRING
             int num = Convert.ToInt32(Console.ReadLine()); 

             int soma = 0;
             for (int i = 1; i <= num; i++){
                 soma += i;
             }

             Console.WriteLine("Soma dos {0} primeiros números: {1}", num, soma);
         }
    }
}