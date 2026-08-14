using System;

namespace maior
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Todos iguais
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Todos os numeros sao iguais.");
            }

            // Empate entre num1 e num2 no maior
            else if (num1 == num2 && num1 > num3)
            {
                Console.WriteLine("Existe empate entre os maiores: " + num1);
            }

            // Empate entre num1 e num3 no maior
            else if (num1 == num3 && num1 > num2)
            {
                Console.WriteLine("Existe empate entre os maiores: " + num1);
            }

            // Empate entre num2 e num3 no maior
            else if (num2 == num3 && num2 > num1)
            {
                Console.WriteLine("Existe empate entre os maiores: " + num2);
            }

            // num1 é o maior
            else if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Maior numero: " + num1);
            }

            // num2 é o maior
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Maior numero: " + num2);
            }

            // Se chegou aqui, num3 é o maior
            else
            {
                Console.WriteLine("Maior numero: " + num3);
            }
        }
    }
}