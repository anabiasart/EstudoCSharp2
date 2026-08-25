using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        int[] evidencias = new int[5];
        bool[] temAliBi = new bool[5];
        for(int i=1; i <= 5; i++)
        {
            Console.WriteLine("Informe o suspeito: "+ i);
            string nome = Console.ReadLine();

            Console.WriteLine("Evidencias: [0 a 5] ");
            int evidencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tem alibi: ");
            Console.WriteLine("[1] Sim: ");
            Console.WriteLine("[2] Nao: ");

            bool alibi = Convert.ToBoolean(Console.ReadLine());

           evidencias[i-1]=evidencia;
           temAliBi[i-1]=alibi;



        }
        for(int i=0; i < temAliBi.Length; i++){
            if(temAliBi[i] == true)
            {
                string

            }
        }

        for(int i=0; i< evidencias.Length; i++)
        {
            if( evidencias[i] <0 || evidencias[i] > 5)
            {
                Console.WriteLine("Invalido, digite novamente");
                i--;
                continue;
            }
            if(evidencias[i] == 0)
            {
                Console.WriteLine("Sem suspeita");
            }if(evidencias[i] == 1 || evidencias[i] == 2)
            {
                Console.WriteLine("suspeito");
            }if(evidencias[i] == 3 || evidencias[i] == 4)
            {
                Console.WriteLine("Fortemente suspeito");
            }if(evidencias[i] == 5)
            {
                Console.WriteLine("Principal suspeito");
            }
        }
    }
}