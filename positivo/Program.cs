using System;

namespace numero.inteiro
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe um numero inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num == 0)
            {
                Console.WriteLine("O numero e zero");
            }else if(num % 2 == 0)
            {
                Console.WriteLine("O numero e par");
            }else
            {
                Console.WriteLine("O numero e impar");

            }if(num < 0)
                {
                    Console.WriteLine("E é negativo");
                }else if(num > 0)
                {
                    Console.WriteLine("Positivo");
                }

        }
    }
}