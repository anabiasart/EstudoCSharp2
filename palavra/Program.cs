using System;

namespace palavra
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite aprimeira string:");
            string p1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda string: ");
            string p2 = Console.ReadLine();

            Console.WriteLine("Digite o tamanho das substrings:");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int contador = 0;

            for(int i =0; i <= p1.Length - tamanho && i <=p2.Length - tamanho; i++)
            {
                string sub1 = p1.Substring(i, tamanho);
                string sub2 = p2.Substring(i, tamanho); 

                if(sub1 == sub2)
                {
                    contador++;
                }   
                
         }
                  Console.WriteLine("Quantidade de substrings iguais: "+ contador);
        }
    }
}