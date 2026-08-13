using System;

namespace proximo
{
    class Program
    {
        static int Numero100(int a, int b)
        {
            
           if(a == b)
           return 0;

           int distanciaA = Math.Abs(100 - a);
           int distanciaB = Math.Abs(100 - b);

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

            int resultado = Numero100(a, b);
            Console.WriteLine($"O número mais próximo de 100 é: {resultado}");
        }
    }
}