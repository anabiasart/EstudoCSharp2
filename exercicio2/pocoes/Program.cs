using System;

class Program
{
    static void Main()
    {
        string[] nomes= new string[5];
        int[] poder = new int[5];
        int[] estoque = new int[5];
        
        bool pode = true;

        while (pode)
        {
            Console.WriteLine("=====LAB====");
            Console.WriteLine("[1] Cadastrar poções");
            Console.WriteLine("[2] Listar Poções ");
            Console.WriteLine("[3] Usar Poção");
            Console.WriteLine("[4] Repor Estoque");
            Console.WriteLine("[5] Buscar poção");
            Console.WriteLine("[6] Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarPocoes(nomes, poder, estoque);
            }
            else if (opcao == 2)
            {
                ListarPocoes(nomes, poder, estoque);
            }else if (opcao == 3)
            {
                 Console.WriteLine("Digite o nome da pocao: ");
                string nomeBuscado = Console.ReadLine();
                                int indice = BuscarPocao(nomes, nomeBuscado);

                if(indice == -1)
                {
                    Console.WriteLine("Poção não encontrada. ");

                }
                else
                {
                    if(estoque[indice] > 0)
                    {
                        estoque[indice] --;

                        Console.WriteLine("Poção utilizada");
                        Console.WriteLine("Poder "+ poder[indice] );
                        Console.WriteLine("Estoque restante: " + estoque[indice]);

                    }
                    else
                    {
                        Console.WriteLine("Poção esgotada!");
                    }
                }

            }
            else if(opcao == 4)
            {
                Console.WriteLine("Digite o nome da pocao: ");
                string nomeBuscado = Console.ReadLine();
                int indice = BuscarPocao(nomes, nomeBuscado);
                  if(indice == -1)
                {
                    Console.WriteLine("Poção não encontrada. ");

                }
                            else
                {
                    Console.WriteLine("===== POÇÃO ENCONTRADA =====");
                    Console.WriteLine("Nome: " + nomes[indice]);
                    Console.WriteLine("Estoque atual: " + estoque[indice]);

                    Console.WriteLine("Quantidade para repor:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    if (quantidade <= 0)
                    {
                        Console.WriteLine("Quantidade inválida!");
                    }
                    else
                    {
                        estoque[indice] += quantidade;

                        Console.WriteLine("Estoque atualizado: " + estoque[indice]);
                    }
                }
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Digite o nome da pocao: ");
                string nomeBuscado = Console.ReadLine();

                int indice = BuscarPocao(nomes, nomeBuscado);

                if(indice == -1)
                {
                    Console.WriteLine("Poção não encontrada. ");

                }
                else
                {
                Console.WriteLine("===== POÇÃO ENCONTRADA =====");
                Console.WriteLine("Nome: " + nomes[indice]);
                Console.WriteLine("Poder: " + poder[indice]);
                Console.WriteLine("Estoque: " + estoque[indice]);
                }
            }
            else if(opcao == 6)
            {
                pode = false;
                Console.WriteLine("Fim lab");
            }
            else
            {
                Console.WriteLine("Opcao invalida");
            }
        }
    }

    static void ListarPocoes(string[] nomes, int[] poder, int[] estoque)
    {
        
        for(int i =0; i < nomes.Length; i++)
        {
         Console.WriteLine("Poção: " + nomes[i]);
        Console.WriteLine("Poder: " + poder[i]);
        Console.WriteLine("Estoque: " + estoque[i]);
        Console.WriteLine();
        }
    }

 
        static void CadastrarPocoes(string[] nomes, int[] poder, int[] estoque)
{
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine("Nome da poção:");
        nomes[i] = Console.ReadLine();

        Console.WriteLine("Poder:");
        int valorPoder = Convert.ToInt32(Console.ReadLine());

        if (valorPoder <= 0)
        {
            Console.WriteLine("Poder inválido!");
            i--;
            continue;
        }

        Console.WriteLine("Estoque:");
        int quantidadeEstoque = Convert.ToInt32(Console.ReadLine());

        if (quantidadeEstoque < 0)
        {
            Console.WriteLine("Estoque inválido!");
            i--;
            continue;
        }

        poder[i] = valorPoder;
        estoque[i] = quantidadeEstoque;
    }
}
 

static int BuscarPocao(string[] nomes, string nomeBuscado)
{
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i] == nomeBuscado)
        {
            return i;
        }
    }

    return -1;
}


}