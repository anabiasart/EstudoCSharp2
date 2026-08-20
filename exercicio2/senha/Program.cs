using System;

class Program
{
    static void Main()
    {   bool temMaiuscula = false;
        bool temMinuscula = false;
        bool temNumero = false;
        bool temEspecial = false;
        bool oitocaracter =false;
        Console.WriteLine("Digite uma senha: ");
        string senha = Console.ReadLine();

        for (int i = 0; i < senha.Length; i++)
      {

          char caractere = senha[i];

            if (char.IsUpper(caractere))//letra maiuscula
            {
                temMaiuscula=true;
            }
            if (char.IsLower(caractere)) //letra minuscula
            {
                temMinuscula=true;
            }
            if (char.IsDigit(caractere))//tem numero de 0a9
            {
                temNumero=true;
            }
            if (!char.IsLetterOrDigit(caractere))
            {
                temEspecial=true;
            }       
} 

                if( senha.Length >= 8)
            {
                oitocaracter=true;
             
            }
                if (oitocaracter &&
                    temMaiuscula &&
                    temMinuscula &&
                    temNumero &&
                    temEspecial)
                {
                    Console.WriteLine("Senha forte!");
                }
                else
                {
                    Console.WriteLine("Senha fraca!");
                }



    }
}


//parentes:char.IsLetter(caractere)        // é uma letra?
//char.IsWhiteSpace(caractere)    // é espaço?
//char.IsPunctuation(caractere)   // é pontuação?
//char.IsLetterOrDigit(caractere) // é letra OU número?