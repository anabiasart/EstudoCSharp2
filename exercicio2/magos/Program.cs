using System;

class Program
{
    static void Main()
    {
        int vida=100;
        int mana = 50;

        int vidaInimigo=120;

        Random random = new Random();
        bool vivo = true;

                static int BolaDeFogo(Random random)
                {
                    
                }
                  static int AtaqueNormal(Random random)
                {
                    int dano = AtaqueNormal(random);
                    vidaInimigo -= dano;

                }
                

        while (vivo)
        {
            Console.WriteLine("======== ARENA ========");

            Console.WriteLine("Sua vida: "+ vida);
            Console.WriteLine("Sua mana: "+ mana);
            Console.WriteLine("Vida inimigo: " + vidaInimigo);

            Console.WriteLine("[1] Ataque normal");
            Console.WriteLine("[2] Bola de fogo");
            Console.WriteLine("[3] Curar");
            Console.WriteLine("[4] Meditar");
int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
              

            }
            if (opcao == 2)
            {
            }


        }

    }
}