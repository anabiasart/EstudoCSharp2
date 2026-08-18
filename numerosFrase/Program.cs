using System;
using System.Net.Http.Headers;
//um programa que pede ao usuario uma frase, e descobre quantos numericos
//existem nela.
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase que deseja analisar:");
        string palavra = Console.ReadLine();
        
        int contador =0;
        

        for (int i = 0; i < palavra.Length; i++)
        {
            char caractere = palavra[i];

            if (char.IsDigit(caractere))
            {
                contador++;
            }
        }
         Console.WriteLine("quantidade de numeros: "+ contador);
    }
}     