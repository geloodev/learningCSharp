using System;

namespace ex01
{

    //cria uma nova classe 'Tempo'
    class Tempo
    {

        private int hora; //usará setters e getters para ser usado
        public int minuto;
        public int segundo;

        //cria um construtor padrão
        public Tempo()
        {
            hora = 23;
            minuto = 59;
            segundo = 59;
        }

        //cria um construtor com parametros
        public Tempo(int tempoHora, int tempoMinuto, int tempoSegundo)
        {
            hora = 23; //caso 'tempoHora' receba um valor inválido, usa o padrão.

            setHora(tempoHora); /* Usa um setter dentro do construtor para
                                   que haja uma validação do dado. */
            minuto = tempoMinuto;
            segundo = tempoSegundo;
        }

        //metodo Setter para campos 'private' 
        public void setHora(int tempoHora)
        {
            if ((tempoHora >= 0) && (tempoHora <= 23)) hora = tempoHora;
        }

        //metodo Getter para campos 'private'
        public int getHora()
        {
            return hora;
        }

        //define um metodo comum
        public int calculaTotalSegundos()
        {
            int totalSegundos = (hora * 3600) + (minuto * 60) + segundo;
            return totalSegundos;
        }

        public void imprimeTempoSimples()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hora, minuto, segundo);
        }

    }
}
