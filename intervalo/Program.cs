using System;
//sem usar Math

namespace intervalo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Resultado: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Resultado: " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Resultado: " + num3);
            }
            else
            {
                Console.WriteLine("Existem números iguais.");
            }
        }
    }
}