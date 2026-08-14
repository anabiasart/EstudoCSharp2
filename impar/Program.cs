using System;

namespace par
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("O numero e zero");
            }else if(num1 % 2 == 0)
            {
                Console.WriteLine("O numero e par");
            }else
            {
                Console.WriteLine("O numero e impar");
            }


        }
    }
}