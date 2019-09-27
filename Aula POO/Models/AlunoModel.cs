using System;

namespace Aula_POO.Models
{
    public class AlunoModel
    { //get, set configura o código acessar ou alterar o atributo; get recebe e set altera.
        // Public diz que o meu atributo é publico, permite que outros podem ler.
        //Void é um metodo sem retorno

        //<summary></summary>
        public string Name {get; set;}

        public string Curso { get; set; }

        public int Rg { get; set; }

        public int Idade { get; set; }

        public void CadastrarAluno(){
            
            System.Console.WriteLine("Insira o nome do aluno");
            Name = Console.ReadLine();

            System.Console.WriteLine("Insira o curso");
            Curso = Console.ReadLine();

            System.Console.WriteLine("Insira a Idade");
            Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira seu Rg");
            Rg = int.Parse(Console.ReadLine());
        }

        public void ListarAluno(){
            System.Console.WriteLine($@"
            Nome: {Name}
            Curso: {Curso}
            Idade: {Idade}
            Rg: {Rg}
            ");   

            }
            public void IrAoBanheiro(){
                System.Console.WriteLine(@"
                ===============================
                   Quero ir ao Banheiro !!!
                ===============================
                ");
                }
        }
    }
