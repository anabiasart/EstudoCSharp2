using System;


class Program
{
    static void Main()
    {
        int aprovados = 0;
        int recuperacao = 0;
        int reprovados =0;
        int soma = 0;
        int maior = int.MinValue;
        int menor = int.MaxValue;
        for(int i = 1; i <= 8; i++)
        {
            Console.WriteLine("Digite uma nota: ");
            int nota = Convert.ToInt32(Console.ReadLine());


            if(nota < 0 || nota > 10)
            {
    Console.WriteLine("Nota invalida. Digite novamente.");
    i--;
    continue;
            }
            if(nota >= 7)
            {
                aprovados++;
            }if(nota>=5 && nota < 7)
            {
                recuperacao++;
            }if(nota < 5)
            {
                reprovados++;
            }
            
            if(nota> maior)
            {
                maior=nota;
            }if(nota < menor)
            {
                menor=nota;
            }
                soma+=nota; 
        }
           double media =(double)soma / 8;

        Console.WriteLine("Aprovados: "+ aprovados);
        Console.WriteLine("Recuperacao: "+ recuperacao);
        Console.WriteLine("Reprovados: "+ reprovados);
        Console.WriteLine("Media: "+ media);
        Console.WriteLine("Maior nota: "+maior);
        Console.WriteLine("Menor: "+ menor);
        
    }
}