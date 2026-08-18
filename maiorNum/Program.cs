using System;
// mostrar qual o maior numero digitado
class Program
{
    static void Main()
    {
        int maior =int.MinValue;
        for(int i=1; i <= 5; i++)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

           if(numero > maior)
            {
                maior=numero;
                

            }
        }

                Console.WriteLine("Maior número: " + maior);

    }
}