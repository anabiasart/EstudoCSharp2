using System;

class Program
{
    static void Main()
    {
            double saldo = 100;
            Random random = new Random();
            bool executando=true;   
            int jogadas = 0;
            int jackpots = 0;
            int vitorias = 0;
            int derrotas = 0;
            double totalApostado = 0;
            double maiorSaldo = saldo;
                

    while(executando){
        Console.WriteLine("=====Caça Niquel=======");
        Console.WriteLine("Saldo: "+ saldo);
        Console.WriteLine("[1] Jogar ");
        Console.WriteLine("[2] Ver estatísticas ");
        Console.WriteLine("[3] Sair ");

        int opcao = Convert.ToInt32(Console.ReadLine());
        if(opcao==1){  Console.WriteLine("Valor da aposta: ");
        double aposta =Convert.ToDouble(Console.ReadLine());
        
        
      

        if (aposta > saldo || aposta <=0)
        {
            Console.WriteLine("Aposta invalida");
            continue;
        }
         
            
                  int numero1 = random.Next(1, 6);
                 int numero2 = random.Next(1, 6);
                 int numero3 = random.Next(1, 6);
                 Console.WriteLine("[ " + numero1 + " ] [ " + numero2 + " ] [ " + numero3 + " ]");

               if (numero1 == numero2 && numero1 == numero3)
                {
                    Console.WriteLine("Jackpot");
                    saldo += aposta * 5;

                    jackpots++;
                }
                else if (numero1 == numero2 ||
                        numero1 == numero3 ||
                        numero2 == numero3)
                {
                    Console.WriteLine("Vitória");
                    saldo += aposta * 2;

                    vitorias++;
                }
                else
                {
                    Console.WriteLine("Derrota");
                    saldo -= aposta;

                    derrotas++;
                }
                Console.WriteLine("Saldo atual: " + saldo);
               jogadas++;
                totalApostado += aposta;

                if (saldo > maiorSaldo)
                {
                    maiorSaldo = saldo;
                }

                Console.WriteLine("Saldo atual: " + saldo);

                if (saldo <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    executando = false;
                }
            }
            else if (opcao == 2)
            {
   
                Console.WriteLine("===== ESTATÍSTICAS =====");
                Console.WriteLine("Jogadas: " + jogadas);
                Console.WriteLine("Jackpots: " + jackpots);
                Console.WriteLine("Vitórias: " + vitorias);
                Console.WriteLine("Derrotas: " + derrotas);
                Console.WriteLine("Total apostado: " + totalApostado);
                Console.WriteLine("Maior saldo alcançado: " + maiorSaldo);

            }
            else if (opcao == 3)
            {
                executando = false;
                    Console.WriteLine("GAME OVER");

            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
    }
    }
    }
