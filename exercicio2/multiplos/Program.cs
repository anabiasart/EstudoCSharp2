using System;


class Program
{
    static void Main()
    {
        int contadorMulti = 0;
        int soma =0;
        int contadorPar = 0;
        int maior = int.MinValue;
        int maior10 = 0;
        for(int i = 1; i<=8; i++)
        {
            Console.WriteLine("Digite um numero: ");
            int numero =Convert.ToInt32(Console.ReadLine());

            if (numero % 3 == 0)
            {
                contadorMulti++;
                soma+=numero;

            }if(numero % 2 == 0)
            {
                contadorPar++;
            }if (numero > maior)
            {
                maior=numero;
            } if(numero > 10)
            {
                maior10++;
            }

        }
         Console.WriteLine("Multiplos 3: "+ contadorMulti);
         Console.WriteLine("Soma dos multiplos: "+ soma);
         Console.WriteLine("Pares: "+ contadorPar);
         Console.WriteLine("Maior: "+ maior);
         Console.WriteLine("Maior que 10: "+ maior10);

    }
}