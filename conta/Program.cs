using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palvra ou frase: ");
        string palavra = Console.ReadLine();

        Console.WriteLine("Digite uma letra que deseja procurar: ");
        char letra = Convert.ToChar(Console.ReadLine());
        
        
        int contador= 0;

        for(int i = 0; i < palavra.Length; i++)
        {
            char comp = palavra[i];
            if (comp == letra)
            {
                contador++;
            }
        }
    Console.WriteLine("quantidade: "+ contador);
    }
}