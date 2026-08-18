using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
//percorrer uma frase e somar os numeros na frase
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com numerais: ");
        string frase = Console.ReadLine();

        int contador = 0;
        for (int i = 0; i < frase.Length; i++)
        {   
            char caractere = frase[i];
            
            if (char.IsDigit(caractere))
            {
                int numero = caractere - '0';
                contador+= numero; //acumula valores
            }
        }
        Console.WriteLine("Somados dos numeros: "+ contador);
    }
}