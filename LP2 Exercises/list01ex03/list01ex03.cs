/*
3. Faça um programa que receba a idade de 10 pessoas (usar valores inteiros). O programa deve:
a) Não contabilizar pessoas com idade fora faixa de 0 a 100 anos;
b) Mostrar a quantidade de pessoas em cada faixa etária: [0-20], [21-40], [41-60], [61-100];
*/

using System;

namespace list01ex03 {

    internal class Program {

        static void Main(string[] args) {

            int num = 0; int ate20 = 0; int ate40 = 0; int ate60 = 0; int ate100 = 0; int cont = 1;

            while (cont <= 10) {

                Console.Write("Digite a idade da pessoa {0}: ", cont);
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0  && num <= 100) {
                    
                    if (num <= 20) ate20++;
                    else if (num <= 40) ate40++;
                    else if (num <= 60) ate60++;
                    else if (num <= 100) ate100++;
                    cont++;
                }
            }

            Console.WriteLine("Total de pessoas na faixa etária   [0-20]: {0}", ate20);
            Console.WriteLine("Total de pessoas na faixa etária  [21-40]: {0}", ate40);
            Console.WriteLine("Total de pessoas na faixa etária  [41-60]: {0}", ate60);
            Console.WriteLine("Total de pessoas na faixa etária [61-100]: {0}", ate100);
            
        }
    }
}