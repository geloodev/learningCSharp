using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores {
    internal class Program {
        static void Main(string[] args) {

            /*
            //forma basica de criar um vetor e inserir valores
            int[] digitos = new int[3];
            digitos[0] = 10;
            digitos[1] = 20;
            digitos[2] = 30;

            //forma completa
            int[] Copas = new int[5] { 1958, 1962, 1970, 1984, 2002 };
            */

            int[] matriculas = new int[4] { 23, 37, 45, 92 }; //vetor original
            int[] referencia = matriculas; //este vetor aponta para o mesmo local

            
            /*
            //'referencia' copiando 'matriculas'
            int referencia = new int[matriculas.Length];
            for (int i = 0; i < matriculas.Length; i++) referencia[i] = matriculas[i];
            */

            referencia[0] = 0;
            referencia[3] = 999;

            for (int i = 0; i < matriculas.Length; i++) {
                Console.Write("{0} ", matriculas[i]);
            }
            Console.WriteLine();
        }
    }
}
