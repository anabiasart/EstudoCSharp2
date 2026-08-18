using System;

class Program
{
    static void Main()
    {
        int menor = int.MaxValue;
        for(int i=1; i <= 6; i++)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero < menor)
            {
                menor=numero;
            }
        }

        Console.WriteLine("Menor numero: "+ menor);
    }
}