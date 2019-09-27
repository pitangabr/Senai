using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Funções");
            
            Console.WriteLine("Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            int resultadoDaSoma = SomaDeDoisNumeros(numero1,numero2);
            Console.WriteLine($"O resultado da soma é {resultadoDaSoma}");

        
        }//fim do main

        /// <summary> Efetua a soma de dois números</summary>
        /// <param nome="a">Primeiro Valor Inteiro </param>
        /// <param nome="b">Segundo Valor Interio</param>
        /// <return> Retorna a soma dos dois Números</return>   
           public static int SomaDeDoisNumeros(int a, int b){

                int soma = a + b;
                return soma;
            } // fim da função SomaDeDoisNumeros
        /// <summary>Retorna o texto de Boas Vindas</summary>
   

            public static string MensagemBoasVindas()
            {
                return " Bem Vindo a Escola Senai de Informática";
            }
    }
}
