using System;

//caso o outro arquivo tenha um namespace diferente:
//using OtherNamespace;

namespace ex01 {

    internal class Program {

        static void Main(string[] args) {

            //variavel capaz de acessar a classe Tempo
            Tempo tempo1;
            
            //função 'new' que referencia a classe ao objeto
            tempo1 = new Tempo();

            //atribui valores aos campos do objeto 'tempo1"
            tempo1.setHora(9); /* Define 'hora' com um setter, ja que hora é 'private'.
                                  Se o valor for inválido, o valor do construtor padrão vai ser usado. */
            tempo1.minuto = 42;
            tempo1.segundo = 28;

            //'{0:D2}' define que o valor sera mostrado em formato de 2 Digitos
            Console.WriteLine("tempo1.hora    {0:D2}", tempo1.getHora()); //usa o metodo getter para usar o campo 'hora'
            Console.WriteLine("tempo1.minuto  {0:D2}", tempo1.minuto);
            Console.WriteLine("tempo1.segundo {0:D2}", tempo1.segundo);
            //chama os metodos
            Console.WriteLine("Total Segundos {0}", tempo1.calculaTotalSegundos());
            tempo1.imprimeTempoSimples();

            //forma mais simples de definir um objeto
            /*
            Tempo tempo2 = new Tempo();
            tempo2.hora = 23;
            tempo2.minuto = 5;
            tempo2.segundo = 30; */

            //define objeto usando o construtor com parametros
            Tempo tempo2 = new Tempo(22, 5, 30);

            Console.WriteLine("\ntempo2.hora    {0:D2}", tempo2.getHora());
            Console.WriteLine("tempo2.minuto  {0:D2}", tempo2.minuto);
            Console.WriteLine("tempo2.segundo {0:D2}", tempo2.segundo);
            Console.WriteLine("Total Segundos {0}", tempo2.calculaTotalSegundos());
            tempo2.imprimeTempoSimples();
        }
    }
}