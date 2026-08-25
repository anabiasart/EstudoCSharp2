using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int vidaJogador =100;
        int vidaInimigo=100;

        Random random = new Random();
        bool batalha= true;

        while (batalha)
        {
            Console.WriteLine("Sua vida: "+ vidaJogador);
            Console.WriteLine("Vida do inimigo: "+ vidaInimigo);
            Console.WriteLine("[1] Atacar");
            Console.WriteLine("[2] Defender");
            Console.WriteLine("[3] Curar");
int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao < 1 || opcao > 3)
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }
            if (opcao == 1)
            {
                int dano = random.Next(10, 26);
                Console.WriteLine("Causou: "+dano);
                vidaInimigo=vidaInimigo-dano;
                if (vidaInimigo > 0)
                {
                    int dano1 = random.Next(8,21);
                    Console.WriteLine("Causou: "+ dano1);
                    vidaJogador=vidaJogador-dano1;
                }
               

            }
            if (opcao == 2)
            {
                    int danoInimigo = random.Next(8, 20);
                Console.WriteLine("O inimigou atacou causando: "+danoInimigo);
                int danoRecebido= danoInimigo / 2;
                Console.WriteLine("Dando recebido: " + danoRecebido);
                vidaJogador = vidaJogador - danoRecebido;
            }
            if (opcao == 3)
            {
                int cura = random.Next(10, 21);
                Console.WriteLine("Curou: "+ cura);
                vidaJogador=vidaJogador+cura;
                if (vidaJogador > 100)
                {
                            vidaJogador = 100;
                }
                int danoInimigo = random.Next(8, 21);

                Console.WriteLine("O inimigo atacou causando: " + danoInimigo);

                vidaJogador = vidaJogador - danoInimigo;
            }
            if (vidaInimigo <= 0)
            {
                Console.WriteLine("Jogador Venceu!!");
                batalha = false;
            }
            else if (vidaJogador <= 0)
            {
                Console.WriteLine("Inimigo Venceu!!");
                batalha = false;
            }


            
        }
    }
}