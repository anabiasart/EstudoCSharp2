using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] salarios = new double[5];
        

        for(int i=1; i <= 5; i++)
        {
            Console.WriteLine("Digite o nome do funcioanrio: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());
           
           if(salario <= 0)
            {
                Console.WriteLine("Salario invalido.Digite novamente");
                i--;
                continue;
            }
            nomes[i -1] =nome;
            salarios[i-1]=salario;
        }

        Console.WriteLine("Digite o nome do funcionario que deseja buscar: ");
        string procura = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < nomes.Length; i++)
{
            if (nomes[i].Equals(procura, StringComparison.OrdinalIgnoreCase))
            {
        encontrado = true;
        Console.WriteLine("Funcionário encontrado!");
        Console.WriteLine("Nome: " + nomes[i]);
        Console.WriteLine("Salário: R$ " + salarios[i]);
        Console.WriteLine("Posição no cadastro: " + (i + 1));
        break;
            }
}
          
            if (encontrado == false)
            {
                Console.WriteLine("Nao encontrado");
            }
        }
    }
