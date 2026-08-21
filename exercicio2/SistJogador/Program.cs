using System;
class Program{
    static void Main()

    {   int [] pontos = new int[5];
        string[] nomes = new string[5]; 
        bool opcao=true;

        int maiorPonto=int.MinValue;
        int menorPonto=int.MaxValue;
        int acimaMedia=0;
        int abaixoMedia=0;
       int soma=0;
       int indiceMaior = 0;
int indiceMenor = 0;
        for(int i=1; i<= 5; i++)
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Pontuação: ");
            int ponto = Convert.ToInt32(Console.ReadLine());

            if(ponto < 0)
            {
                Console.WriteLine("Pontuação invalida! Digite novamente: ");
                i--;
                continue;
            }
            if (ponto > maiorPonto)
            {
                maiorPonto=ponto;
                indiceMaior=i-1;

            }
            if (ponto < menorPonto)
            {
                menorPonto=ponto;
                indiceMenor=i-1;
            }
           soma+=ponto;
           pontos[i-1]=ponto;
           nomes[i-1]= nome;
        }
        double media= soma /5.0;
        for(int i =0; i< pontos.Length; i++)
        {
            if(pontos[i] > media)
            {
                acimaMedia++;
            }if(pontos[i] < media)
            {
                abaixoMedia++;
            }
        }
        Console.WriteLine("Maior pontuação: " + maiorPonto);
        Console.WriteLine("Jogador: " + nomes[indiceMaior]);
        Console.WriteLine("Menor pontuação: " + menorPonto);
        Console.WriteLine("Jogador: " + nomes[indiceMenor]);
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Acima da média: " + acimaMedia);
        Console.WriteLine("Abaixo da média: " + abaixoMedia);

        while(opcao)
        {
            Console.WriteLine("======MENU======");
            Console.WriteLine("[1] Ranking");
            Console.WriteLine("[2] Buscar jogador");
            Console.WriteLine("[3] Campeão");
            Console.WriteLine("[4] Ultimo colocado");
            Console.WriteLine("[5] Sair");
             int escolha = Convert.ToInt32(Console.ReadLine());


        if(escolha == 1)
{

 for(int i = 0; i < pontos.Length - 1; i++)
{
    for(int j = i + 1; j < pontos.Length; j++)
    {
        if(pontos[i] < pontos[j])
        {
            int tempPonto = pontos[i];
            pontos[i] = pontos[j];
            pontos[j] = tempPonto;

            string tempNome = nomes[i];
            nomes[i] = nomes[j];
            nomes[j] = tempNome;
        }
    }
}
Console.WriteLine("===== RANKING =====");

for(int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine((i + 1) + "º - " + nomes[i] + " - " + pontos[i] + " pontos");
}
}
    else if(escolha == 2)
    {
        Console.WriteLine("Nome do jogador: ");
        string busca=Console.ReadLine();
    bool encontrou = false;

        for(int i = 0; i < nomes.Length; i++)
                {
                   if(nomes[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Jogador encontrado"+ nomes[i]);
                        Console.WriteLine("Pontuação: "+ pontos[i]);

                        encontrou=true;
                        break;
                    }
                }
                if (!encontrou)
                {
                            Console.WriteLine("Jogador não encontrado.");

                }               
                
                    }
    else if(escolha == 3)
    {
         Console.WriteLine("Campeão: " + nomes[indiceMaior]);
         Console.WriteLine("Pontuação: " + pontos[indiceMaior]);
    }
    else if(escolha == 4)
    {
         Console.WriteLine("Último colocado: " + nomes[indiceMenor]);
         Console.WriteLine("Pontuação: " + pontos[indiceMenor]);
    }
    else if(escolha == 5)
    {
        opcao = false;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
        }
   
    }
      
}