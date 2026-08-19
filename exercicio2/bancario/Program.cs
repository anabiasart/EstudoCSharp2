using System;

class Program
{
    static void Main()
    {
        double saldo = 1000;
        int escolha =0;
       while(escolha !=4)
        {   

            Console.WriteLine("[1] - Consultar saldo");
            Console.WriteLine("[2] - Depositar");
            Console.WriteLine("[3] - Sacar");
            Console.WriteLine("[4] - Sair");
            escolha=Convert.ToInt32(Console.ReadLine());
              
            if(escolha == 1)
            {
                Console.WriteLine("Saldo atual: "+ saldo);
            }else if(escolha == 2)
            {
                Console.WriteLine("Valor do deposito: ");
                double deposito = Convert.ToInt32(Console.ReadLine());
            }
               else if (escolha == 2)
                {
                    Console.WriteLine("Valor do deposito: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());

                    if (deposito <= 0)
                    {
                        Console.WriteLine("Valor invalido.");
                        continue;
                    }

                    saldo += deposito;
                }
            
            else if (escolha == 3)
            {
                Console.WriteLine("Informe o valor do saque: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                if(valor < 0 || valor > saldo)
                {
                    Console.WriteLine("Saldo insuficiente ou valor invalido");
                    continue;
                }
                saldo -= valor;
            }
                else if(escolha ==4)
                {   
                    Console.WriteLine("Programa encerado");
            }
            else
            {
                Console.WriteLine("Opcao invalida");
            }
            }
        }
    }
