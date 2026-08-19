using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        double media=0;
      double maior = double.MinValue;
double menor = double.MaxValue;
        int aprovados =0;
        int recuperacao =0;
        int reprovados=0;
        int acimamedia=0;
        double soma=0;
            double[]notas = new double[8];

        for(int i =1; i <= 8; i++)
        {
            Console.WriteLine("Digite uma nota: ");
            double nota = Convert.ToDouble(Console.ReadLine());

           if (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida. Digite novamente.");
    i--;
    continue;
}
            if (nota > maior)
            {
                maior=nota;
            }
            if (nota < menor)
            {
                menor=nota;
            }
            if (nota >= 7)
            {
                aprovados++;
            }else if(nota>=5 && nota < 7)
            {
                recuperacao++;
            }
            else
            {
                reprovados++;
            }
            soma+=nota;
           
            notas[i - 1] = nota;
        }  
         media = soma / 8;
        for (int i = 0; i < notas.Length; i++)
        {
             if (notas[i] > media)
                {
                   acimamedia++;
                }
        }Console.WriteLine("Média: " + media);
Console.WriteLine("Maior nota: " + maior);
Console.WriteLine("Menor nota: " + menor);
Console.WriteLine("Aprovados: " + aprovados);
Console.WriteLine("Recuperação: " + recuperacao);
Console.WriteLine("Reprovados: " + reprovados);
Console.WriteLine("Acima da média: " + acimamedia);


            
    }
}