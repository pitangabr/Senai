using System;
using POOexercicios.Models;

namespace POOexercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0; int contador = 0;

            do{
            Console.WriteLine("Escolha suas Opções para Objetos");
            Console.WriteLine("1 - Celular");
            Console.WriteLine("2 - Oculos");
            Console.WriteLine("3 - Avião");
            Console.WriteLine("4 - Microondas");
            Console.WriteLine("5 - Porta");
            Console.WriteLine("0 - Sair");

            switch (opcao){
                case 1:
                Console.WriteLine("Escolha sua Opção");
                string resposta; 
            }


            CelularModel celulares = new CelularModel ();
            //----OBJETO OCULOS----
            OculosModel oculos = new OculosModel();

            System.Console.WriteLine("Insira o nome do objeto");
            oculos.Name = Console.ReadLine();

            System.Console.WriteLine("Insira o Modelo");
            oculos.Modelo = Console.ReadLine();

            System.Console.WriteLine("Insira a cor do objeto");
            oculos.cor = Console.ReadLine();

            System.Console.WriteLine("Digite o tamanho do objeto");
            oculos.Tamanho = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a marca");
            oculos.Marca = Console.ReadLine();

            System.Console.WriteLine("Digite o seu Grau");
            oculos.Grau = double.Parse(Console.ReadLine());

            System.Console.WriteLine($@"
            Nome: {oculos.Name}
            Modelo: {oculos.Modelo}
            Cor: {oculos.cor}
            Tamanho: {oculos.Tamanho}
            Marca: {oculos.Marca}
            Grau: {oculos.Grau}
            ");
            } while();
        }
    }
}
