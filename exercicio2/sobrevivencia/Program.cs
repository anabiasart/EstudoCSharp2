using System;

class Program
{
    static void Main()
    {
        int vida = 100;
        int comida = 3;
        int agua = 3;
        int municao = 5;
        int dia = 1;

        Random random = new Random();
        bool vivo = true;

        while(vivo){

      Console.WriteLine("====== DIA " + dia + " ======");
        Console.WriteLine("Vida: "+ vida);
        Console.WriteLine("Comida: "+ comida);
        Console.WriteLine("Agua: "+ agua);
        Console.WriteLine("Municao: "+municao);

        Console.WriteLine("[1] Explorar");
        Console.WriteLine("[2] Descansar");
        Console.WriteLine("[3] Procurar recursos");
        Console.WriteLine("[4] Ver inventário");

int opcao = Convert.ToInt32(Console.ReadLine());
if (opcao < 1 || opcao > 4)
{
    Console.WriteLine("Opção inválida!");
    continue;
}
            if (opcao == 1)
            {
                int evento = random.Next(1,5);

                if (evento == 1)
                {
                    int quantidade = random.Next(1, 4);
                    comida += quantidade;

                    Console.WriteLine("Encontrou comida: " + quantidade);
                }
               else if(evento == 2)
        {
                    int quantidade = random.Next(1, 4);
                    agua += quantidade;

                    Console.WriteLine("Encontrou agua: " + quantidade);
                }
     

                else if (evento == 3)
                {
                    int quantidade = random.Next(1, 4);
                    municao += quantidade;

                    Console.WriteLine("Encontrou municao: " + quantidade);
                }
                else 
                {
                    Console.WriteLine("Encontrou um zumbi");
                    Console.WriteLine("[1] Atirar");
                    Console.WriteLine("[2] Fugir");
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        if(municao> 0){
                        municao--;
                        Console.WriteLine("Zumbi morre");}
                        else
                        {
                           int dano = random.Next(10, 26);
                            vida -= dano;

                            Console.WriteLine("Você estava sem munição e sofreu " + dano + " de dano.");
                        }
                    }
                    if (escolha == 2)
                    {
                        int chance = random.Next(1,3);
                        if(chance == 1)
                        {
                            Console.WriteLine("Consegue fugir");
                        }if(chance == 2)
                        {
                                  int danoZumbi = random.Next(10, 26);
                                    vida -= danoZumbi;
                                    Console.WriteLine("O inimigou atacou causando: "+danoZumbi);
                                    Console.WriteLine("Vida restante: " + vida);
                        }
                    }
                }
            }
            if (opcao == 2)
                {
                    if (comida <= 0 || agua <= 0)
                    {
                        Console.WriteLine("Você não possui comida ou água suficiente para descansar.");
                        continue;
                    }

                    int cura = random.Next(10, 21);

                    vida += cura;

                    if (vida > 100)
                    {
                        vida = 100;
                    }

                    Console.WriteLine("Você descansou e recuperou " + cura + " de vida.");
                }
            if (opcao == 3)
            {
                int recurso = random.Next(1,5);
                if (recurso == 1)
                        {
                            comida++;
                            Console.WriteLine("Você encontrou comida.");
                        }
                        else if (recurso == 2)
                        {
                            agua++;
                            Console.WriteLine("Você encontrou água.");
                        }
                        else if (recurso == 3)
                        {
                            municao++;
                            Console.WriteLine("Você encontrou munição.");
                        }
                        else
                        {
                            Console.WriteLine("Você não encontrou nada.");
                        }
            }
            if (opcao == 4)
            {
                Console.WriteLine("===== INVENTÁRIO =====");
                Console.WriteLine("Vida: " + vida);
                Console.WriteLine("Comida: " + comida);
                Console.WriteLine("Água: " + agua);
                Console.WriteLine("Munição: " + municao);

                continue;
            }
     
            if (comida > 0)
                {
                    comida--;
                }
                else
                {
                    vida -= 10;
                    Console.WriteLine("Você está sem comida e perdeu 10 de vida.");
                }

                if (agua > 0)
                {
                    agua--;
                }
                else
                {
                    vida -= 15;
                    Console.WriteLine("Você está sem água e perdeu 15 de vida.");
                }

                dia++;
                if (vida <= 0)
                    {
                        Console.WriteLine("Você não sobreviveu.");
                        vivo = false;
                    }
                    else if (dia > 10)
                    {
                        Console.WriteLine("Você sobreviveu por 10 dias!");
                        vivo = false;
                    }
        }
    }
}