using System;

class Program
{
    static void Main()
    {   
        int letras=0;
        int numeros=0;
        int espacos=0;
        int especiais=0;
        int vogais=0;
        int consoantes=0;
        string vogal = "aeiou";
  
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
   

        for(int i=0;i < frase.Length; i++)
        {
            char caractere = frase[i];
          
            if (char.IsLetter(caractere))
            {
                letras++;
                char letra = char.ToLower(caractere);

            if (vogal.Contains(letra))
                {
                    vogais++;
                }
                else
                {
                    consoantes++;
                }
                
            }
            if (char.IsDigit(caractere))
            {
                numeros++;
            }if (char.IsWhiteSpace(caractere))
            {
                espacos++;

            }if (!char.IsLetterOrDigit(caractere) && !char.IsWhiteSpace(caractere))
            {
                especiais++;
            }

        }
                Console.WriteLine("Letras: " + letras);
                Console.WriteLine("Vogais: " + vogais);
                Console.WriteLine("Consoantes: " + consoantes);
                Console.WriteLine("Numeros: " + numeros);
                Console.WriteLine("Espacos: " + espacos);
                Console.WriteLine("Especiais: " + especiais);

    }
}