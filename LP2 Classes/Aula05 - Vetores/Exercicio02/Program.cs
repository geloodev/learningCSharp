using System;

namespace Program {
    
    internal class Program {

        static void Main(string[] args) {

            //PERGUNTA QUAL O TAMANHO DA TURMA
            Console.Write("A turma possui quantos alunos?: ");
            int numAlunos = Convert.ToInt32(Console.ReadLine());
            Aluno[] alunos = new Aluno[numAlunos];

            //DEFINE OS DADOS DOS ALUNOS
            for (int i = 0; i < alunos.GetLength(0); i++) {
                alunos[i].setNome();
                alunos[i].setRa();
                alunos[i].setNota1();
                alunos[i].setNota2();
            }

            //MOSTRA O RELATORIO DOS DADOS
            Console.WriteLine("\n\nRELATÓRIO DE SITUAÇÃO DA TURMA:");
            Console.WriteLine("\nAPROVADOS:");
            for (int i = 0; i < alunos.GetLength(0); i++) {
                if (alunos[i].situacaoAluno() == "APROVADO") Console.WriteLine(alunos[i].getNome);
            }
            Console.WriteLine("\nREPROVADO:");
            for (int i = 0; i < alunos.GetLength(0); i++) {
                if (alunos[i].situacaoAluno() == "REPROVADO") Console.WriteLine(alunos[i].getNome);
            }
            Console.WriteLine("\nIFA:");
            for (int i = 0; i < alunos.GetLength(0); i++) {
                if (alunos[i].situacaoAluno() == "IFA") Console.WriteLine(alunos[i].getNome);
            }
            
        }
    }
}