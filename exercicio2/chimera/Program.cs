using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        int[] inteligencia = new int[5];
        int[] agressividade = new int[5];
        int[] estabilidade = new int[5];
        bool[] contida = new bool[5];

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Me informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Inteligencia: ");
            int inteligente = Convert.ToInt32(Console.ReadLine());

  if (inteligente > 100 || inteligente < 0)
            {
                Console.WriteLine("Valor inválido!");
                i--;
                continue;
            }


         Console.WriteLine("Agressividade: ");
            int agressivo = Convert.ToInt32(Console.ReadLine());

            if (agressivo > 100 || agressivo < 0)
            {
                Console.WriteLine("Valor inválido!");
                i--;
                continue;
            }

            Console.WriteLine("Estabilidade: ");
            int estabili = Convert.ToInt32(Console.ReadLine());

              if (estabili > 100 || estabili < 0)
            {
                Console.WriteLine("Valor inválido!");
                i--;
                continue;
            }

            nomes[i - 1] = nome;
            inteligencia[i - 1] = inteligente;
            agressividade[i - 1] = agressivo;
            estabilidade[i - 1] = estabili;

    
    Console.WriteLine("A criatura está contida?");
    Console.WriteLine("[1] Sim");
    Console.WriteLine("[2] Não");

    int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            contida[i - 1] = true;
        }
        else if (opcao == 2)
        {
            contida[i - 1] = false;
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            i--;
            continue;
        }
                }
            }}
        
