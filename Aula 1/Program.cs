﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Alunos");

            Pessoa pessoa = new Pessoa();


            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o numero do  telefone: ");
            pessoa.NumeroTelefone = Console.ReadLine();

            string dados = pessoa.DadosPessoa();
            Console.WriteLine(dados);

            pessoa.Gravar(pessoa);

            //List<Pessoa> pessoas = pessoa.Ler();

            //foreach (Pessoa p in pessoas)
            //{
            //    Console.WriteLine(p.DadosPessoa());

            //}


            Console.ReadLine();

            




        }
    
    }
}
