using System;

class Program
{
    static void Main()
    {
        int[] codigos = new int[5];
        string[] nomes = new string[5];
        double[] precos = new double[5];
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Codigo produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            if(codigo <= 0 || preco <= 0)
            {
                Console.WriteLine("Dados invalidos, digite novamente: ");
                i--;
                continue;
            }
            bool repetido = false;

                for (int j = 0; j < i - 1; j++)
                {
                    if (codigos[j] == codigo)
                    {
                        repetido = true;
                        break;
                    }
                }

                if (repetido)
                {
                    Console.WriteLine("Codigo ja cadastrado. Digite outro.");
                    i--;
                    continue;
                }

            nomes[i-1]=nome;
            codigos[i-1]=codigo;
            precos[i-1]=preco;

        }
        Console.WriteLine("Digite o código do produto que deseja buscar: ");
        int procura = Convert.ToInt32(Console.ReadLine());
        bool encontrado =false;

        for(int i=0; i < codigos.Length; i++)
        {
            if (codigos[i].Equals(procura))
            {
                encontrado = true;
                Console.WriteLine("Produto encontrado!");
                Console.WriteLine("Codigo: "+ codigos[i]);
                Console.WriteLine("Produto: "+ nomes[i]);
                Console.WriteLine("Preço: "+ precos[i]);

                if (precos[i] < 100)
                {
                    Console.WriteLine("Preco baixo");
                }else if(precos[i]>= 100 && precos[i] <= 500)
                {
                    Console.WriteLine("Preco medio");
                }
                else if (precos[i]>500)
                {
                    Console.WriteLine("Preco alto");
                }
break;            
                
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("nao encontrado");
        }

    }
}