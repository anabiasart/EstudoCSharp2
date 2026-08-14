using System;

namespace media
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a primeira nota do aluno: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if(num1 < 0 || num1 > 10)
            {
                Console.WriteLine("Nota invalida: " + num1);
                return;
            }else if(num2 <0 || num2 > 10)
            {
                Console.WriteLine("Nota invalida: " + num2);
                return;
            }
        
            
            double media = (num1 + num2) / 2;
            Console.WriteLine("Media: "+ media);
            if(media >= 7)
            {   
                Console.WriteLine("Aprovado");
            }else if(media >= 5 && media < 7)
            {
                Console.WriteLine("Recuperação");
            }else if(media < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("invalido");
            }
        }
    }
}