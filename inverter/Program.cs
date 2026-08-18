using System;
using System.Diagnostics.Contracts;
//Faça um programa que peça uma 
// palavra ao usuário e mostre essa palavra ao contrário.
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        
        
        for(int i = palavra.Length - 1; i >=0; i--)
        {
               Console.Write(palavra[i]);

        }


    }
}