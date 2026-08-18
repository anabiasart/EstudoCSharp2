using System;

class Program
{
    static void Main()
    {
        int menor = int.MaxValue;
        int maior = int.MinValue;
        for(int i =1; i<= 5; i++)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > maior)
            {
                maior =numero;
            } if(numero < menor)
            {
                menor=numero;
            }
        }
        Console.WriteLine("Maior numero: " + maior);
        Console.WriteLine("Menor numero: "+ menor);
    }
}