using System;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach


        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {   
           
            var xNotasZuqui = new List<int>() { 7, 6, 5, 3 };
            var xNotasBronza = new List<int>() { 8, 9, 10, 8 };
            var xMediaAlunoZuqui = CalcularMedia(xNotasZuqui);
            var xMediaAlunoBronza = CalcularMedia(xNotasBronza);

            Console.WriteLine("Media do Zuqui:" + xMediaAlunoZuqui);

            Console.WriteLine("Media do Bronza: " + xMediaAlunoBronza);

            if(xMediaAlunoZuqui >= 7){
                Console.WriteLine("Passou no ano letivo");
            }
            else{
                Console.WriteLine("Não passou no ano letivo");
            }

            if(xMediaAlunoBronza >= 7){
                Console.WriteLine("Passou no ano letivo");
            }
            else{
                Console.WriteLine("Não passou no ano letivo");
            }
        }

        public static float CalcularMedia(List<int> pNotas)
        {
                //var MediaAluno = 0.0f;
                var SomaNotas = 0.0f;
                var QttNotas = 0;

                    foreach (var xNota in pNotas)
                    {
                        SomaNotas+=xNota;
                        QttNotas++;
                    }
                    return (SomaNotas/QttNotas);

        }
    }
}
