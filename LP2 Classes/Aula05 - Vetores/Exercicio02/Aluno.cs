using System;

namespace Program {

    internal class Aluno {

        private string nome;
        private int ra;
        private double nota1;
        private double nota2;

        public Aluno() {
            nome = "A";
            ra = 1;
            nota1 = 0.00;
            nota2 = 0.00;
        }

        //GETTERS
        public string getNome() {
            return nome;
        }
        public int getRa() {
            return ra;
        }
        public double getNota1() {
            return nota1;
        }
        public double getNota2() {
            return nota2;
        }

        //SETTERS
        public void setNome() {
            Console.Write("Informe o nome: ");
            nome = Convert.ToString(Console.ReadLine());
        }
        public void setRa() {
            Console.Write("Informe o RA: ");
            ra = Convert.ToString(Console.ReadLine());
        }
        public void setNota1() {
            do {
                Console.Write("Informe a nota 1: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                verificaNota(nota1);

            }while (false);
        }
        public void setNota2() {
            do {
                Console.Write("Informe a nota 2: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                verificaNota(nota2);

            }while (false);
        }

        //OUTROS METODOS
        public bool verificaNota(double nota) {
            bool verificacao;
            if (nota >= 0.00 && nota <= 10.00) verificacao = true;
            else {
                Console.WriteLine("\nNota inválida.");
                verificacao = false;
            }
            return verificacao;
        }
        public double calculaMedia() {
            double media = (nota1 + nota2) / 2.00;
            return media;
        }
        public string situacaoAluno() {
            string situacao;

            if(media < 4) situacao = "REPROVADO";
            else if (media < 6) situacao = "IFA";
            else situacao = "APROVADO";

            return situacao;
        }
    }
}
