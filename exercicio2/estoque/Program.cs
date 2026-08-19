using System;

class Program
{
    static void Main()
    {int[] quantidades = new int[6];
    string[] produtos = new string[6];
        int maior=int.MinValue;
        int menor=int.MaxValue;
      string nomeMaior = "";
string nomeMenor = "";
        int total=0;
        int menor5=0;
        for(int i=1; i <= 6; i++)
        {
            Console.WriteLine("Nome do Produto: " + i);
            string produto = Console.ReadLine();
     
            Console.WriteLine("Quantidade do produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
       if (quantidade < 0)
{
    Console.WriteLine("Quantidade inválida. Digite novamente.");
    i--;
    continue;
}produtos[i - 1] = produto;
quantidades[i - 1] = quantidade;
            if (quantidade > maior)
            {   
                maior=quantidade;
                nomeMaior=produto;

                }
                if (quantidade < menor)
                {
                    menor=quantidade;
                    nomeMenor=produto;
                }if(quantidade < 5)
                {
                    menor5++;
                }
                total+=quantidade;




        }

       Console.WriteLine("Total de itens: " + total);

Console.WriteLine("Maior estoque: " + nomeMaior);
Console.WriteLine("Quantidade: " + maior);

Console.WriteLine("Menor estoque: " + nomeMenor);
Console.WriteLine("Quantidade: " + menor);

Console.WriteLine("Produtos com estoque baixo: " + menor5);

Console.WriteLine("\nProdutos que precisam de reposição:");

for (int i = 0; i < produtos.Length; i++)
{
    if (quantidades[i] < 5)
    {
        Console.WriteLine(produtos[i]);
    }
}

    }
}