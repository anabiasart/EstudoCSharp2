using System;

class Program
{
    static void Main()
    {
        string[] tarefas = new string[5];
        bool[]concluidas = new bool[5];
        for (int i=1; i <=5; i++)
        {
            Console.WriteLine("Cadastre a tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas[i-1] = tarefa;
        }
        
        
        Console.WriteLine("Qual tarefa quer marcar como concluida? ");
        int opcao = Convert.ToInt32(Console.ReadLine());

       if (opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opcao invalida.");
            }
            else
            {
                concluidas[opcao -1]=true;
            }
             for (int i = 0; i < tarefas.Length; i++)
            {
                if (concluidas[i])
                {
                    Console.WriteLine((i + 1) + " - " + tarefas[i] + " [Concluida]");
                }
                else
                {
                    Console.WriteLine((i + 1) + " - " + tarefas[i] + " [Pendente]");
                }
            }
           
        
    }
}