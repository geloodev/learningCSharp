using System;

namespace ex01 {

    internal class Program {

        static void Main(string[] args) {

            //muda o titulo de console
            Console.Title = "Exercicio 01";
            
            // Pede o nome e salva na variavel nome
            Console.Write("Entre com o seu nome: ");
            string? nome = Console.ReadLine();

            //Pede a idade e salva na variavel idade
            Console.Write("Entre com a sua idade: ");
            string? idade = Console.ReadLine();

            //limpa o console
            Console.Clear();

            //define as cores do texto e do background no console
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Imprime uma mensagem utilizando as variaveis informadas
            Console.WriteLine("Olá {0}! A sua idade é de {1} anos.", nome, idade);

            Console.ResetColor();
            Console.WriteLine("\nPograma executado com sucesso!");

            double num = 10.57;
            int num2 = 133;
            
            //apresenta numeros em forma de moeda
            Console.WriteLine("\n{0:C}", num);

            //numero em forma decimal
            Console.WriteLine("{0:D5}", num2);
        }
    } 
}