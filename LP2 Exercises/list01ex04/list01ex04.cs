/*
4. Faça um programa que receba um número e que calcule a tabuada desse número. O programa deve:
a) Aceitar números de 1 a 10. Caso seja entrado um número fora dessa faixa deve mostrar uma mensagem
de erro e terminar a execução do programa.
b) Mostrar o nome da tabuada por extenso. Ex: “Tabuada do OITO”;
c) Mostrar a tabuada do número;
*/

using System;

namespace list01ex04 {

    internal class Program {

        static void Main(string[] args) {
            
            Console.Write("Escolha uma tabuada [1 a 10]: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num > 10) {
                Console.WriteLine("Tabuada Inválida!");
            }
            else {
                
                Console.Write("\nTabuada do ");
                if (num == 1) Console.WriteLine("UM:");
                else if (num == 2) Console.WriteLine("DOIS:");
                else if (num == 3) Console.WriteLine("TRÊS:");
                else if (num == 4) Console.WriteLine("QUATRO:");
                else if (num == 5) Console.WriteLine("CINCO:");
                else if (num == 6) Console.WriteLine("SEIS:");
                else if (num == 7) Console.WriteLine("SETE:");
                else if (num == 8) Console.WriteLine("OITO:");
                else if (num == 9) Console.WriteLine("NOVE:");
                else if (num == 10) Console.WriteLine("DEZ:");

                for (int cont = 1; cont <= 10; cont++) Console.WriteLine("{0} X {1} = {2}", num, cont, num*cont);

            }
        }
    }
}