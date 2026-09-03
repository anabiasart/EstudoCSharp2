using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[6];
        int[] oxigenio = new int[6];
        int[] temperatura = new int[6];
        int[] radiacao = new int[6];
        bool[] portaEmergencia = new bool[6];

        int seguro = 0;
        int perigo = 0;
        int critico = 0;
        int perdido = 0;

        int maiorRadiacao = int.MinValue;
        int menorOxigenio = int.MaxValue;

        string nomeMaiorRadiacao = "";
        string nomeMenorOxigenio = "";

        int somaOxigenio = 0;
        double mediaOxigenio = 0;

        // CADASTRO DOS SETORES
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine();
            Console.WriteLine("===== SETOR " + (i + 1) + " =====");

            Console.WriteLine("Nome do setor:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Nivel de oxigenio: 0 a 100");
            oxigenio[i] = Convert.ToInt32(Console.ReadLine());

            if (oxigenio[i] < 0 || oxigenio[i] > 100)
            {
                Console.WriteLine("Oxigenio invalido!");
                i--;
                continue;
            }

            Console.WriteLine("Nivel de temperatura: -50 a 100");
            temperatura[i] = Convert.ToInt32(Console.ReadLine());

            if (temperatura[i] < -50 || temperatura[i] > 100)
            {
                Console.WriteLine("Temperatura invalida!");
                i--;
                continue;
            }

            Console.WriteLine("Nivel de radiacao: 0 a 100");
            radiacao[i] = Convert.ToInt32(Console.ReadLine());

            if (radiacao[i] < 0 || radiacao[i] > 100)
            {
                Console.WriteLine("Radiacao invalida!");
                i--;
                continue;
            }

            Console.WriteLine("Porta de emergencia funcionando? (true/false)");
            portaEmergencia[i] = Convert.ToBoolean(Console.ReadLine());

            // ESTATISTICAS
            somaOxigenio += oxigenio[i];

            if (oxigenio[i] < menorOxigenio)
            {
                menorOxigenio = oxigenio[i];
                nomeMenorOxigenio = nomes[i];
            }

            if (radiacao[i] > maiorRadiacao)
            {
                maiorRadiacao = radiacao[i];
                nomeMaiorRadiacao = nomes[i];
            }
        }

        mediaOxigenio = somaOxigenio / 6.0;

        Console.WriteLine();
        Console.WriteLine("========== ANALISE DOS SETORES ==========");

        // ANALISE
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Setor: " + (i + 1));
            Console.WriteLine("Nome: " + nomes[i]);
            Console.WriteLine("Oxigenio: " + oxigenio[i] + "%");
            Console.WriteLine("Temperatura: " + temperatura[i]);
            Console.WriteLine("Radiacao: " + radiacao[i]);
            Console.WriteLine("Porta funcionando: " + portaEmergencia[i]);

            if (oxigenio[i] >= 60 &&
                radiacao[i] <= 30 &&
                temperatura[i] >= 10 &&
                temperatura[i] <= 35)
            {
                Console.WriteLine("STATUS: SEGURO");
                seguro++;
            }
            else if (oxigenio[i] >= 30 &&
                     radiacao[i] <= 70)
            {
                Console.WriteLine("STATUS: PERIGO");
                perigo++;
            }
            else if ((oxigenio[i] < 30 || radiacao[i] > 70) &&
                     portaEmergencia[i] == false)
            {
                Console.WriteLine("STATUS: PERDIDO");
                perdido++;
            }
            else if ((oxigenio[i] < 30 || radiacao[i] > 70) &&
                     portaEmergencia[i] == true)
            {
                Console.WriteLine("STATUS: CRITICO - EVACUAR!");
                critico++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("========== RELATORIO FINAL ==========");

        Console.WriteLine("Setores seguros: " + seguro);
        Console.WriteLine("Setores em perigo: " + perigo);
        Console.WriteLine("Setores criticos: " + critico);
        Console.WriteLine("Setores perdidos: " + perdido);

        Console.WriteLine();

        Console.WriteLine(
            "Maior radiacao: " +
            nomeMaiorRadiacao +
            " - " +
            maiorRadiacao
        );

        Console.WriteLine(
            "Menor oxigenio: " +
            nomeMenorOxigenio +
            " - " +
            menorOxigenio +
            "%"
        );

        Console.WriteLine("Media de oxigenio: " + mediaOxigenio);

        Console.WriteLine();
        Console.WriteLine("========== EVACUACAO DISPONIVEL ==========");

        for (int i = 0; i < 6; i++)
        {
            bool setorCritico =
                oxigenio[i] < 30 ||
                radiacao[i] > 70;

            bool setorPerdido =
                setorCritico &&
                portaEmergencia[i] == false;

            if (portaEmergencia[i] == true &&
                setorPerdido == false)
            {
                Console.WriteLine("- " + nomes[i]);
            }
        }
    }
}