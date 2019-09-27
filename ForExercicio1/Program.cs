using System;

namespace ForExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Vamos saber o seu Nome, Idade, Peso, Altura e Sexo:");
            // Console.ReadLine();

            string[] nomes = new string [2];
            double[] idades = new double [2];
            double[] peso = new double [2];
            double[] altura = new double [2];
            string [] sexo = new string [2];

            
            for (int contador = 0; contador < 2; contador++)
            {
            Console.WriteLine($"Digite o seu {contador+1}º nome:");    
            nomes [contador] = Console.ReadLine();

            Console.WriteLine($"Digite sua idade:");
            idades [contador] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite seu peso:");
            peso [contador] = double.Parse (Console.ReadLine());

            Console.WriteLine ($"Digite sua altura:");
            altura [contador] = double.Parse (Console.ReadLine());

            Console.WriteLine($"Qual seu sexo: F/M");
            sexo [contador] = Console.ReadLine();
            } // fim do for

            //CALCULOSSSSSS 

            int totalM = 0;
            int totalF = 0;
            double mediaF = 0;
            double mediaM = 0;
            // double totalIdade = 0;
            int contadorB;

            for(contadorB = 0; contadorB <2; contadorB++){
                if (sexo[contadorB] == "M")
                {
                    totalM = totalM + 1;
                    mediaM = mediaM+idades[contadorB];
                    // mediaIdM = totalIdade/2;
                }else {
                    totalF = totalF +1;
                    mediaF= mediaF+idades[contadorB];
                    // mediaIdF = totalIdade/2;
                }
            }


            Console.WriteLine($"Total Média Homens: {mediaM} e Total Média Mulheres: {mediaF}");
            Console.WriteLine ($"Total de Homens: {totalM} e Total de Mulheres: {totalF}");

            



          


        }
    }
}
