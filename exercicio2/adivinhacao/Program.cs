using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto =random.Next(1,101);
        int tentativas=0;
        bool acertou=false;

      

    while(!acertou)
    {
         Console.WriteLine("Digite seu palpite: ");
        int palpite = Convert.ToInt32(Console.ReadLine());
    
    if (palpite < 1 || palpite > 100)
    {
        Console.WriteLine("Palpite invalido.");
        continue;
    }

    tentativas++;

        if(palpite < numeroSecreto)
        {
            Console.WriteLine("O numero é maior");

        }else if(palpite > numeroSecreto)
        {
            Console.WriteLine("Numero é menor");

        }
       else
            {
                acertou = true;
                tentativas++;

                Console.WriteLine("Voce acertou!");
                Console.WriteLine("Tentativas: " + tentativas);
            }
    
}
}
}
       
