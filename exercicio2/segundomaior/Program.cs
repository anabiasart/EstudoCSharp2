using System;

class Program
{
    static void Main()
    {
        int maior = int.MinValue;
        int segmaior = int.MinValue;
        int negativo=0;
        int soma = 0;
        
        for(int i = 1; i <= 7; i++)
        {

            Console.WriteLine("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            if(numero > maior)
            {   segmaior = maior;
                maior=numero;
            }else if(numero > segmaior)
            {
                segmaior=numero;
            }if (numero < 0)
            {
                negativo++;
            }
             soma+=numero;

          
        }

        Console.WriteLine("Maior" + maior);
        Console.WriteLine("Segundo maior: "+ segmaior);
        Console.WriteLine("Negativos: "+ negativo);
        Console.WriteLine("Soma: "+ soma);
        
    }
}