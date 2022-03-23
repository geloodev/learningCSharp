using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista
            List<int> numeros = new List<int>();

            //insere elementos no final da lista;
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(4);
            numeros.Add(4);
            numeros.Add(5);

            //insere elemento em uma dada posição
            numeros.Insert(2, 3); //Insert(posicao, elemento)
            numeros.Insert(1, 10);

            //procura e remore o elemento 10
            numeros.Remove(10);

            //encontra a posição da primeira ocorrencia do elemento "4"
            int index = numeros.IndexOf(4);
            if (index >= 0)
            {
                //remove o elemento da posição achada pelo index
                numeros.RemoveAt(index);
            }

            
            Console.Write("Lista: \n");
            /* for (int i = 0; i < numeros.Count; i++) //Count para contar o numero de elementos da lista
            {
                Console.Write("{0}\t", numeros[i]);
            } */

            //função 'for' mais compacta e simples
            foreach(int valor in numeros)
            {
                Console.Write("{0}\t", valor);
            }
            

            Console.WriteLine();
        }
    }
}
