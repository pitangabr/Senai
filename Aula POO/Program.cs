using System;
using Aula_POO.Models;

namespace Aula_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console é uma Classe.
            //WriteLine é uma função.
            //Esta criando um aluno que tem caracteristicas Model, acessando da aba AlunoModel,tem que esta público.
            //Ctrl+. chama o arquivo para esta página.
            AlunoModel aluno1 = new AlunoModel();

            //Console.Clear limpa o Console, só mostra o que tem em baixo, é um metodo.
            Console.Clear();

            aluno1.CadastrarAluno();
            aluno1.ListarAluno();
            aluno1.IrAoBanheiro();




            // System.Console.WriteLine("Insira o nome do aluno");
            // aluno1.Name = Console.ReadLine();

            // System.Console.WriteLine("Insira o curso");
            // aluno1.Curso = Console.ReadLine();

            // System.Console.WriteLine("Insira a Idade");
            // aluno1.Idade = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Insira seu Rg");
            // aluno1.Rg = int.Parse(Console.ReadLine());

            //@ da as separações, lista as variáveis dadas, sem precisar repetir.
            // System.Console.WriteLine($@"
            // Nome: {aluno1.Name}
            // Curso: {aluno1.Curso}
            // Idade: {aluno1.Idade}
            // Rg: {aluno1.Rg}
            // ");
        }
    }
}






