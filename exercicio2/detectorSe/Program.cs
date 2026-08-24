using System;

class Program
{
    static void Main()
    { 
        int anterior = 0;
        int maiorAumento=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um numero inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (i > 1)
                {
                    if (numero > anterior)
                    {
                        int aumento = numero - anterior;

                        if (aumento > maiorAumento)
                        {
                            maiorAumento = aumento;
                        }
                    }
                }

                anterior = numero;
            }
            Console.WriteLine("Maior aumento: " + maiorAumento);
    }
}