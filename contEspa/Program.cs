using System;
using System.Security.Cryptography;
//contar quantos espacos tem em uma frase

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase que desejar: ");
        string frase = Console.ReadLine();

        int contador = 0;

        for(int i = 0; i < frase.Length; i++)
        {
            char vazio = frase [i];
            if (vazio==' ')
            {
                contador++;
            }
        }
        Console.WriteLine("Quantidade: "+ contador);
    }
}