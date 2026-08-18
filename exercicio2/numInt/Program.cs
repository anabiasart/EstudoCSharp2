using System;

class Program
{
    static void Main()
    {   
        double soma = 0;
        double maior = int.MinValue;
        double menor = int.MaxValue;
                   

        for(int i = 1; i <= 6; i++)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            double  numero =  Convert.ToInt32(Console.ReadLine());
            
            if(numero > maior)
            {
                maior = numero;
            }if(numero < menor)
            {
                menor = numero;
            }
                soma+=numero;
      
           
        }
        double media = soma / 6;
            Console.WriteLine("Maior: "+ maior);
            Console.WriteLine("Menor: "+ menor);
            Console.WriteLine("Soma: "+ soma);
            Console.WriteLine("Media: "+ media);

    }
}