using System;

namespace ProdutosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Produtos com FOR");

            string[] produtoNome = new string [3];
            double[] produtoPreco = new double [3];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço:");
                produtoPreco[i] = double.Parse(Console.ReadLine());
            } // fim do for

            int contador = 0;
            foreach (var produto in produtoNome)
            {
                // Console.WriteLine($"Produto: {produto}");
                //Para cada produto em produtoNome{coca,fanta,pepsi}
                Console.WriteLine($"Produto: {produto} preço: {produtoPreco[contador]}");
                contador++;
            } // fim foreach

            for(int i = 0; i < 3; i++){
                // no for consigo acessar quantos arrays forem necessários
                Console.WriteLine($"Produto: {produtoNome[i]} Preço: {produtoPreco[i]}");
            }//fim for
        }
    }
}
