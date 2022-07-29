using System;
using System.Collections.Generic;

//POO Calcula idade
namespace pooCalculaIdade
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que calculdade idade");
            
            Pessoa pessoa = new Pessoa();

            Console.Write("Nome da pessoa:");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Ano de Nascimento:");
            pessoa.AnoNascimento = int.Parse(Console.ReadLine());

            pessoa.ExibirDados();
            Console.ReadKey();
    

        }
    }
}

