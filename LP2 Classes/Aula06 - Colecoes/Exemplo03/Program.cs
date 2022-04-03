using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um dicionário de strings utilizando uma string como chave
            //Dictionary<chave, valor>
            Dictionary<string, string> programa = new Dictionary<string, string>(); 
            

            //adiciona alguns elementos no dicionário
            //não é permitida a entrada de chaves duplicadas, mas pode ter valores duplicados
            programa.Add("txt", "notepad.exe");
            programa.Add("bmp", "paint.exe");
            programa.Add("dib", "paint.exe");
            programa.Add("rtf", "wordpad.exe");
            
            //função para evitar que um possível erro ocorra, substituindo ele por outro comando
            try {
                programa.Add("txt", "winword.exe");
            }
            catch (ArgumentException) {
                Console.WriteLine("Já existe um elemento com a chave = \"txt\"."); // \" serve para utilizar as aspas como texto
            }
            
            //recupera um valor a partir de uma chave
            Console.WriteLine("\".rtf\" -> {0}", programa["rtf"]);
            
            //muda o valor associado a uma chave
            programa["rtf"] = "winword.exe";
            Console.WriteLine("\".rtf\" -> {0}", programa["rtf"]);

       
            
            
            //'Constainskey' verifica se o dicionário já contém a chave
            if (programa.ContainsKey("bmp"))
            {
                Console.WriteLine("\".bmp\" -> {0}", programa["bmp"]); ;
            }
            
            /// caso uma chave requisitada não exista no dicionário é gerada uma exceção
            try
            {
                Console.WriteLine("\".tif\" -> {0}", programa["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("chave = \"tif\" não encontrada.");
            }
            
            //recupera todas as chaves do dicionário
            Console.WriteLine("\nChaves:");
            foreach (string s in programa.Keys)
            {
                Console.WriteLine(" " + s);
            }
            
            //recupera todos os valores do dicionário
            Console.WriteLine("\nValores:");
            foreach (string s in programa.Values)
            {
                Console.WriteLine(" " + s);
            }
            
            //remove o elemento com a chave passada
            programa.Remove("txt");
            
            //recupera todos elementos (chave - valor) do dicionário
            Console.WriteLine("\nElementos");
            foreach (KeyValuePair<string, string> kvp in programa)
            {
                Console.WriteLine("chave = {0}, valor = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
