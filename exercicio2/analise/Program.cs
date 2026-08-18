using System;

class Program
{
    static void Main()
    {
        int positivo =0;
        int negativo = 0;
        int zero = 0;
        double soma = 0;
        double somaN =0;
        for(int i =1; i <= 10; i++)
        {
            Console.WriteLine("Digite um numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());
               
            if(numero > 0)
            {
                positivo++;
                soma += numero;

            }
            if (numero < 0)
            {
                negativo++;
                somaN += numero;

            }if(numero == 0)
            {
                zero++;
            }

        }

        Console.WriteLine("Positivo: "+ positivo);
        Console.WriteLine("Negativo: "+ negativo);
        Console.WriteLine("SomaPositivo: "+ soma);
        Console.WriteLine("SomaNeg: "+ somaN);
        Console.WriteLine("Zeros:"+ zero);
    }
}