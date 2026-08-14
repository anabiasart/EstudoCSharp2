using System;
using System.Runtime.InteropServices;

namespace calculator
{
    class Program
    {
        static void Main()
        {
        
            Console.WriteLine("Digte o primeiro numero:");
          double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digte o segundo numero:");
           double num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("1-Somar");
            Console.Write("2-Subtrair ");
            Console.Write("3-Multiplicar ");
            Console.Write("4-Dividir ");
            Console.WriteLine("Escolha uma operação: ");
           string escolha = Console.ReadLine();
            
            if (escolha == "1")
            {
                double somatoria = num1+num2;
                Console.WriteLine("Resultado: " + somatoria);
            }else if (escolha == "2")
            {
                double sub = num1-num2;
                Console.WriteLine("Resultado: " + sub);

            }else if(escolha == "3")
            {
                double  multi= num1 * num2;
                Console.WriteLine("Resultado:" + multi);
            }else if(escolha == "4")
            {
                 if (num2 == 0)
    {
        Console.WriteLine("Não é possível dividir por zero.");
    }else{
                double divi = num1 / num2;
                Console.WriteLine("Resultado: "+ divi);
    }
            }
            else
{
    Console.WriteLine("Operacao invalida.");
}
            }


        }
    }
