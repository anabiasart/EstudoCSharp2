using System;

class Program
{
    static void Main()
    {
        double maior = double.MinValue;
        double menor = double.MaxValue;
        double media =0;
        double soma=0;
        int ma3 =0;
        int ma2 = 0;
        int me2 =0;

        for(int i=1; i <= 10; i++)
        {
            Console.WriteLine("Digite o salario de cada: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if(salario <= 0)
            {
                Console.WriteLine("Salário invalido. Digite novamente.");
                     i--;
                        continue;
            }if(salario > maior)
            {
                maior=salario;
            }if(salario > 3000)
            {
                ma3++;
            }else if (salario >= 2000 && salario <= 3000)
            {
                ma2++;
            }

            if(salario < menor)
            {
                menor=salario;
            }if(salario < 2000)
            {
                me2++;
            }

             soma+=salario;
             media = soma / 10;
        }
        Console.WriteLine("Maior: "+ maior);
        Console.WriteLine("Menor: "+ menor);
        Console.WriteLine("Media: "+ media);
        Console.WriteLine("Recebem mais de 3k: "+ ma3);
        Console.WriteLine("Recebem entre 2 a 3k: "+ ma2);
        Console.WriteLine("Recbeme menos de 2k:" + me2 );
        Console.WriteLine("Soma: "+ soma);
    }
}