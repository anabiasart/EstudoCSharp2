using System;

class Program
{
    static void Main()
    {
        double[] horas = new double[7];
        double soma=0;
        double horaMaior=double.MinValue;
        double horaMenor=double.MaxValue;
        int diaMaior=0;
        int diaMenor=0;
        int acimaMedia=0;
        int abaixoMedia=0;
        int igual=0;
        int zero=0;


        for(int i=1; i<=7; i++)
        {
            Console.WriteLine("Horas estudadas dia: "+ i);
            double hora = Convert.ToDouble(Console.ReadLine());

            if (hora < 0)
            {
                Console.WriteLine("Valor invalido digite novamente: ");
                i--;
                continue;
            }
            if (hora > horaMaior)
            {
                horaMaior=hora;
                diaMaior=i; //guardar o dia

            }
            if (hora < horaMenor)
            {
                horaMenor=hora;
                diaMenor=i;
            }
            soma+=hora;
            horas[i - 1] = hora;


        }
            double media = soma / 7;
                for (int i = 0; i < horas.Length; i++)
                {
                    if (horas[i] > media)
                    {
                        acimaMedia++;
                    }
                    else if (horas[i] < media)
                    {
                        abaixoMedia++;
                    }
                    else
                    {
                        igual++;
                    }

                    if (horas[i] == 0)
                    {
                        zero++;
                    }
                }
                Console.WriteLine("\n--- RESULTADOS ---");

                    Console.WriteLine("Total de horas estudadas: " + soma);
                    Console.WriteLine("Media de horas por dia: " + media);

                    Console.WriteLine("Maior quantidade de horas: " + horaMaior);
                    Console.WriteLine("Dia com maior quantidade de horas: " + diaMaior);

                    Console.WriteLine("Menor quantidade de horas: " + horaMenor);
                    Console.WriteLine("Dia com menor quantidade de horas: " + diaMenor);

                    Console.WriteLine("Dias acima da media: " + acimaMedia);
                    Console.WriteLine("Dias abaixo da media: " + abaixoMedia);
                    Console.WriteLine("Dias iguais a media: " + igual);
                    Console.WriteLine("Dias sem estudo: " + zero);

        }
    }
