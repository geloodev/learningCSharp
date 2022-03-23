using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria um conjunto (igual lista, mas sem itens repetidos)
            HashSet<int> conjunto = new HashSet<int>();

            //adiciona elementos no conjunto
            conjunto.Add(3);
            conjunto.Add(1);
            conjunto.Add(2);
            conjunto.Add(2);
            conjunto.Add(5);
            conjunto.Add(4);
            conjunto.Add(5);

            //mostra os elementos do conjunto
            MostraConjunto("Novo conjunto: ", conjunto);

            //remove a primeira instância do elemento 1 do conjunto
            conjunto.Remove(1);

            //mostra os elementos do conjunto
            MostraConjunto("Remoção de elementos: ", conjunto);

            //verifica se o conjunto contém o número 5
            if (conjunto.Contains(5))
            {
                Console.WriteLine("Conjunto contém o elemento 5!");
            }
        }

        //método auxiliar para imprimir o conteúdo do conjunto
        private static void MostraConjunto(string text, HashSet<int> conj)
        {
            Console.Write(text + "{");
            
            for (int i = 0; i < conj.Count; i++)
            {
                Console.Write(" {0}", conj.ElementAt(i));
            }

            Console.WriteLine(" }");
        }
        
    }
}
