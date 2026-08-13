using System;

namespace proximo.cinquenta
{
    class Program
    {
        static int cinquenta(int a, int b)
        {
            if (a==b)
            return 0;

            int distanciaA = Math.Abs(50 - a);
            int distanciaB = Math.Abs(50 - b);

            if(distanciaA < distanciaB)
                return a;
            else
                return b;

        }

        static void Main()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = cinquenta(a, b);
            Console.WriteLine($"O número mais próximo de 50 é: {resultado}");
        }
    }
}