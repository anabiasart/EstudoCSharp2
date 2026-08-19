using System;

class Program
{
    static void Main()
    {   double[] temperaturas = new double[7];
        double maior=double.MinValue;
        double menor=double.MaxValue;
        double media=0;
        int diasacima=0;
        int diasabaixo=0;
        int diasigual=0;
double soma = 0;
        int diaMaior=0;
        int diaMenor=0;

        for(int i=1; i <= 7; i++)
        {
            Console.WriteLine("Digite a temperatura do dia "+ i);
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura > maior)
            {
                maior=temperatura;
                diaMaior=i;

            }
            if (temperatura < menor)
            {
                menor=temperatura;
                diaMenor=i;
            }
                soma += temperatura;
                    temperaturas[i - 1] = temperatura;
        }

        media=soma / 7;
        for(int i=0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > media)
            {
                diasacima++;
            }else if(temperaturas[i] < media)
            {
                diasabaixo++;
            }else
            {
                diasigual++;
            }
        }
        Console.WriteLine("Media: "+ media);
        Console.WriteLine("Maior temp: "+ maior);
        Console.WriteLine("Ocorreu dia: "+ diaMaior);
        Console.WriteLine("Menor temp: "+ menor);
        Console.WriteLine("Ocorreu dia: "+ diaMenor);
        Console.WriteLine("Dias acima da media: "+ diasacima);
        Console.WriteLine("Dias abaixo: "+ diasabaixo);
        Console.WriteLine("Dias igual: "+ diasigual);
    }
}