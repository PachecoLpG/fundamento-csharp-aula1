using System;
using System.Collections.Generic;
using System.Linq;

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
            var xPessoas = new List<Pessoa>();
            xPessoas.Add(new Pessoa
            {
                Idade = 31,
                Nome = "Zuqui"
            });
            xPessoas.Add(new Pessoa
            {
                Idade = 27,
                Nome = "Bronza"
            });
            var xMediaIdadePessoas = xPessoas.Select(p => p.Idade).Average();
            var xIdadePessoaMaisVelha = xPessoas.Select(p => p.Idade).Max(); 
            var xIdadePessoaMaisNova = xPessoas.Select(p => p.Idade).Min();
            var xPessoaMaisVelha = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault();
            var xPessoaMaisNova = xPessoas.OrderBy(p => p.Idade).FirstOrDefault();
            var xQuatidadeDeMaiores = xPessoas.Select(p => p.Idade >=18).Count();

            Console.WriteLine("Media de idade das pessoas: " + xMediaIdadePessoas + " anos");
            Console.WriteLine("Pessoa mais velha: " + xPessoaMaisVelha.Nome + " " + xIdadePessoaMaisVelha + " anos");
            Console.WriteLine("Pessoa mais nova: " + xPessoaMaisNova.Nome + " " + xIdadePessoaMaisNova + " anos");
            Console.WriteLine("Pessoas maiores de idade: " + xQuatidadeDeMaiores + " pessoa(s)");

        }

         public class Pessoa
           {
               public string Nome { get; set; }
               public int Idade { get; set; }

           }

    }
}
