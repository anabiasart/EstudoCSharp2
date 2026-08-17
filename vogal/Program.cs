using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou uma frase: ");
       string palavra = Console.ReadLine();

string vogais = "aeiou";
int contador = 0;

for (int i = 0; i < palavra.Length; i++)
{
    char letra = palavra[i];

    if (vogais.Contains(letra))
    {
        contador++;
    }
}

Console.WriteLine("Quantidade: " + contador);

}}