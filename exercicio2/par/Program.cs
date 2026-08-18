using System;

class Program
{
    static void Main()
    {   
        int contadorImpar = 0;
        int contadorPar=0;
        int somaPar=0;
        for(int i = 1; i <= 8; i++)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            

            if(numero % 2 == 0)
            {   

                contadorPar++;
                somaPar+=numero;
            }
            else
            {
                contadorImpar++;
            }

        }

        Console.WriteLine("Pares: "+ contadorPar);
        Console.WriteLine("Impares: "+ contadorImpar);
        Console.WriteLine("Soma dos Pares: "+ somaPar);
    }
}