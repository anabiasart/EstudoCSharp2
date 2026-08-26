using System;

class Program
{
    static void Main()
    {
        int vida = 100;
        int mana = 50;
        int vidaInimigo = 120;

        Random random = new Random();

        bool vivo = true;

        while (vivo)
        {
            Console.WriteLine("======== ARENA ========");
            Console.WriteLine("Sua vida: " + vida);
            Console.WriteLine("Sua mana: " + mana);
            Console.WriteLine("Vida inimigo: " + vidaInimigo);

            Console.WriteLine("[1] Ataque normal");
            Console.WriteLine("[2] Bola de fogo");
            Console.WriteLine("[3] Curar");
            Console.WriteLine("[4] Meditar");

            int opcao = Convert.ToInt32(Console.ReadLine());
if (opcao < 1 || opcao > 4)
{
    Console.WriteLine("Opção inválida!");
    continue;
}
            if (opcao == 1)
            {
                int dano = AtaqueNormal(random);

                vidaInimigo -= dano;

                Console.WriteLine("Você causou " + dano + " de dano!");
            }

         
          if (opcao == 2)
            {
              if (mana >= 15)
            {
                int dano = BolaDeFogo(random);

                vidaInimigo -= dano;
                mana -= 15;

                Console.WriteLine("Você lançou uma bola de fogo!");
                Console.WriteLine("Dano causado: " + dano);
            }
            else
            {
                Console.WriteLine("Mana insuficiente!");
                    continue;

            }
        }

            
            if (opcao == 3)
            {
                if (mana >= 10)
                {
                    int cura = Curar(random);
                    vida+=cura;
                    mana -=10;

                    if (vida > 100)
                    {
                        vida=100;
                    }
            Console.WriteLine("Recuperou: "+ cura + "de vida");
                }
                else
                {
                    Console.WriteLine("Mana insuficiente!");
                        continue;

                }
            }
            if (opcao == 4)
            {
               
                if (mana == 50)
                {
                    Console.WriteLine("Sua mana já está cheia!");
                    continue;
                }
                int manaRecuperada = Meditar(random);

                mana+= manaRecuperada;

                if(mana > 50)
                {
                    mana=50;
                }
                Console.WriteLine("Recuperou: " + manaRecuperada + "de mana");
            }

            if (vidaInimigo <= 0)
            {
                Console.WriteLine("VOCÊ VENCEU!");
                vivo = false;
                continue;
            }
            int danoInimigo = AtaqueInimigo(random);

            vida -= danoInimigo;

            Console.WriteLine("O inimigo causou " + danoInimigo + " de dano!");
            if (vida <= 0)
            {
                Console.WriteLine("VOCÊ MORREU!");
                vivo = false;
            }
        }
    }

    static int AtaqueNormal(Random random)
    {
        int dano = random.Next(10, 21);

        return dano;
    }

    static int BolaDeFogo(Random random)
    {
        int dano = random.Next(25, 41);

        return dano;
    }

    static int Curar(Random random)
    {
        int cura = random.Next(15,31);
        return cura;
    }
    
    static int Meditar (Random random)
    {
        int manaRecuperada = random.Next(10,21);
        return manaRecuperada;
    }
    static int AtaqueInimigo(Random random)
        {
            int dano = random.Next(8, 19);
            return dano;
        }
}