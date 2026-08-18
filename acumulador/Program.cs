using System;

class Program
{
    static void Main()
    {
        
        double media;
        double soma =0;
        for(int i =1; i <= 5; i++)
        {
            Console.WriteLine("Digite uma nota: ");
            double numero = Convert.ToDouble(Console.ReadLine());
         soma += numero;    

                   
        }
            
            
            media = soma / 5;
            Console.WriteLine("A media e: "+ media);

        
    }
    
}