using System;

namespace Numero
{
    class Program
    {
        static string VerificarNumero(int num)
        {
            if (num > 0)
            {
                return "Positivo";
            }
            else if (num<0)
            {
                return "Negativo";
            }
            else
            {
                return "Zero";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            string resultado = VerificarNumero(num);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}