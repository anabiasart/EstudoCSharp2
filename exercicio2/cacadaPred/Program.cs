using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Dutch", "Billy", "Mac", "Dillon", "Anna" };
        int[] distancia = { 80, 35, 60, 20, 100 };
        int[] ameaca = { 9, 7, 6, 8, 2 };
        bool[] armado = { true, true, true, true, false };
        bool[] detectado = { false, false, false, false, false };

        int[] nivelScan = new int[5];

        Random random = new Random();

        bool sorteio = true;

        while (sorteio)
        {
            int indice = random.Next(0, nomes.Length);

            Console.WriteLine("ASSINATURA TÉRMICA DETECTADA");

        
                
            if (nivelScan[indice] < 3)
                {
                    nivelScan[indice]++;
                }
             if (nivelScan[indice] == 1)
                {
                    Console.WriteLine("Distância: " + distancia[indice]);
                }
                else if (nivelScan[indice] == 2)
                {
                    Console.WriteLine("Distância: " + distancia[indice]);
                    Console.WriteLine("Armado: " + armado[indice]);
                }
                else
                {
                    Console.WriteLine("Distância: " + distancia[indice]);
                    Console.WriteLine("Armado: " + armado[indice]);
                    Console.WriteLine("Ameaça: " + ameaca[indice]);
                    Console.WriteLine("Identidade: " + nomes[indice]);
                }
            if(nivelScan[indice] == 3)
            {
                detectado[indice] = true;
            }

            int totalDetectados = 0;

            for(int i=0;i< detectado.Length; i++)
            {
                if(detectado[i] == true)
                {
                    totalDetectados++;

                }
               
               
            }
             Console.WriteLine("Alvos identificados: " + totalDetectados);
                 if (totalDetectados >= 3)
                {
                    Console.WriteLine("Dados suficientes para iniciar a caçada.");
                    sorteio = false;
                }
int[] prioridade = new int[5];
int maiorPrioridade = int.MinValue;
int indiceMaisPerigoso = -1;
                for (int i = 0; i < nomes.Length; i++)
{
    if (detectado[i] == true)
    {
        prioridade[i] = ameaca[i] * 2;

        if (armado[i] == true)
        {
            prioridade[i] += 5;
        }

        if (distancia[i] < 30)
        {
            prioridade[i] += 4;
        }
        else if (distancia[i] <= 60)
        {
            prioridade[i] += 2;
        }
    }
}

            for (int i = 0; i < prioridade.Length; i++)
            {
                if (detectado[i] == true && prioridade[i] > maiorPrioridade)
                {
                    maiorPrioridade = prioridade[i];
                    indiceMaisPerigoso = i;
                }
            }

            Console.WriteLine("===== ANÁLISE DO VISOR =====");

            Console.WriteLine(
                "Alvo prioritário: " + nomes[indiceMaisPerigoso]);

            Console.WriteLine(
                "Prioridade: " + maiorPrioridade);
                    }
                    
                     Console.WriteLine("Alvos identificados");
                     

                }
       
}