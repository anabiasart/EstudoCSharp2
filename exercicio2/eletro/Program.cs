using System;

class Program
{
    static void Main()
    {
       
       Console.WriteLine("Digite o valor do saque:");
       int valor = Convert.ToInt32(Console.ReadLine());

      if(valor <= 0)
        {
            Console.WriteLine("Valor invalido: ");
            return;
        } 
        int valorOriginal = valor;
        Console.WriteLine("Valor solicitado: R$ " + valorOriginal);
                int notas100 = valor /100;
                valor = valor % 100;

                int notas50= valor /50;
                valor = valor%50;

                int notas20 = valor /20;
                valor =  valor % 20;

                int notas10= valor/10;
                valor = valor % 10;
                
                int notas5 = valor/5;
                valor = valor % 5;

                int notas2 = valor/2;
                valor = valor % 2;


            Console.WriteLine("notas de 100: "+ notas100);
            Console.WriteLine("Notas de 50: "+notas50);
            Console.WriteLine("Notas de 20"+ notas20);
            Console.WriteLine("Notas de 10"+ notas10);
            Console.WriteLine("Notas de 5"+ notas5);
            Console.WriteLine("Notas de 2: "+ notas2);
Console.WriteLine("Valor restante: R$ " + valor);





    }
}