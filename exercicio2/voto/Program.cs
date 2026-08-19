using System;

class Program
{
    static void Main()
    {
        int votosA=0;
        int votosC=0;
        int votosM=0;
        int opcao=0;
        while(true)
        {
            Console.WriteLine("[1] Ana");
            Console.WriteLine("[2] Carlos");
            Console.WriteLine("[3] Maria");
            Console.WriteLine("[0] Encerrar votação");

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao== 0)
            {
                Console.WriteLine("Encerrado.");
                break;
            }else if( opcao == 1)
            {
                votosA++;

            }else if(opcao == 2)
            {
                votosC++;
            }else if(opcao == 3)
            {
                votosM++;
            }
            else
            {
                Console.WriteLine("Numero invalido, digite novamente: ");
                continue;
            }
               


        }
                int total = votosA + votosC + votosM;

                Console.WriteLine("Ana: " + votosA);
                Console.WriteLine("Carlos: " + votosC);
                Console.WriteLine("Maria: " + votosM);
                Console.WriteLine("Total de votos: " + total);

              if (total > 0)
                {
                    double porcentagemA = (double)votosA / total * 100;
                    double porcentagemC = (double)votosC / total * 100;
                    double porcentagemM = (double)votosM / total * 100;

                    Console.WriteLine("Ana: " + porcentagemA + "%");
                    Console.WriteLine("Carlos: " + porcentagemC + "%");
                    Console.WriteLine("Maria: " + porcentagemM + "%");
                }

                 if (votosA > votosC && votosA > votosM)
                    {
                        Console.WriteLine("Vencedora: Ana");
                    }
                    else if (votosC > votosA && votosC > votosM)
                    {
                        Console.WriteLine("Vencedor: Carlos");
                    }
                    else if (votosM > votosA && votosM > votosC)
                    {
                        Console.WriteLine("Vencedora: Maria");
                    }
                    else
                    {
                        Console.WriteLine("Eleição empatada.");
                    }
                    }
}