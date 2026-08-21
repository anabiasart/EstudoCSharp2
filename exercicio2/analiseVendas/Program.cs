using System;

class Program
{
    static void Main()
    {
     double[] vendas = new double[10];

        double maiorVenda= double.MinValue;
        double menorVenda= double.MaxValue;
        double soma = 0;
        
        int diasacima=0;
        int diasabaixo=0;
        int diasigual=0;
        int diaMmedia=0;

        for(int i=1;i <= 10; i++)
        {
            Console.WriteLine("Valor da venda do dia: "+ i);
            double venda = Convert.ToDouble(Console.ReadLine());

            if (venda < 0)
            {
                Console.WriteLine("Valor invalido! Informe novamente: ");
                i--;
                continue;

            }     if(venda > maiorVenda)
                    {
                        maiorVenda=venda;

                    } 
                    if (venda < menorVenda)
                    {
                        menorVenda=venda;
                    }
                    if (venda == 0)
                    {
                        diasigual++;
                    }
                    else if (venda > 1000)
                    {
                        diasacima++;
                    }
                    else if (venda < 500)
                    {
                        diasabaixo++;
                    }

                    soma+=venda;
                    vendas[i-1] = venda;

                    }

     double media= soma / 10;
     for(int i=0; i < vendas.Length; i++)
        {
            if(vendas[i] > media)
            {
                diaMmedia++;
            }
        }


Console.WriteLine("\n--- RESULTADO ---");
Console.WriteLine("Total vendido: R$ " + soma);
Console.WriteLine("Média de vendas: R$ " + media);
Console.WriteLine("Maior venda: R$ " + maiorVenda);
Console.WriteLine("Menor venda: R$ " + menorVenda);
Console.WriteLine("Dias com vendas acima de R$ 1000: " + diasacima);
Console.WriteLine("Dias com vendas abaixo de R$ 500: " + diasabaixo);
Console.WriteLine("Dias sem vendas: " + diasigual);
Console.WriteLine("Dias acima da média: " + diaMmedia);

        }

    }

