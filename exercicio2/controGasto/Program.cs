        using System;

        class Program
        {
            static void Main()
            {
                
                    double[] gastos = new double [7];
                    double soma=0;
                    int diaMaior=0;
                    int diaMenor=0;
                    double maiorGasto=int.MinValue;
                    double menorGasto=int.MaxValue;
                    double acimaMedia=0;
                    double abaixoMedia=0;
                    double gastosIgual=0;
                    int zero=0;
                    for(int i =1; i <= 7; i++)
                {
                    Console.WriteLine("Registre o gasto do dia  "+ i);
                    double gasto = Convert.ToDouble(Console.ReadLine());

                    if (gasto < 0)
                    {
                        Console.WriteLine("Valor invalido! Insira novamente: ");
                        i--;
                        continue;
                    }
                    if (gasto > maiorGasto)
                    {
                        maiorGasto=gasto;
                        diaMaior++;
                    }if(gasto < menorGasto)
                    {
                        menorGasto=gasto;
                        diaMenor++;
                    }
        soma+=gasto;
        gastos[i-1]=gasto;
        }
                
        double media=soma / 7;
                    for(int i = 0; i < gastos.Length; i++)
                    {
                        if(gastos[i] > media)
                        {
                            acimaMedia++;
                        }if (gastos[i] < media)
                        {
                            abaixoMedia++;
                        }
                        if (gastos[i] == media)
                        {
                            gastosIgual++;
                        }if(gastos[i] == 0)
                        {
                            zero++;
                        }
                    }
                }
                
            }
        