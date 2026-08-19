using System;

class Program
{
    static void Main()
    {
        int positivo = 0;
        int negativo =0;
        int pares =0;
        int impar=0;
        int soma=0;
        int maior=int.MinValue;
        int menor=int.MaxValue;
        int zero=0;
        for(int i =1; i <= 10; i++)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
          
         if (numero > 0)
            {
                positivo++;
            }else if(numero < 0)
            {
                negativo++;
            }if(numero == 0)
            {
                zero++;
            }if (numero % 2 == 0)
            {
                pares++;
            }if (numero % 2 != 0)
            {
                impar++;
            }if (numero > maior)
            {
                maior=numero;
            }if(numero < menor)
            {
                menor=numero;
            }
            soma+=numero;

        }
        Console.WriteLine("Positivo: "+ positivo);
        Console.WriteLine("Negativos: "+ negativo);
        Console.WriteLine("Zeros: "+ zero);
        Console.WriteLine("Pares: "+ pares);
        Console.WriteLine("Impares: "+ impar);
        Console.WriteLine("Soma: "+ soma);
        Console.WriteLine("Maior: "+ maior);
        Console.WriteLine("Menor: "+ menor);
    }
}