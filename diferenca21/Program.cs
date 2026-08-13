using System;

namespace exercicio.vinte
{
    class Program
    {
        static bool diferenca(int a, int b)
        {
            if (a == 21 || b == 21)
            {
                return true;
            }
            else if (Math.Abs(a - b) == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            bool resultado = diferenca(a, b);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}