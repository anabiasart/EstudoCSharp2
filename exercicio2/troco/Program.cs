using System;

class Program
{
    static void Main()
    {
        bool executando =true;
    while(executando){

        int opcao=0;

        Console.WriteLine("Valor da compra: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor recebido: ");
        double recebido  = Convert.ToDouble(Console.ReadLine());
        
        if(valor <= 0)
        {
            Console.WriteLine("Valor da compra invalido!");
            continue;
        }if(recebido < valor)
        {  
            Console.WriteLine("Valor insuficiente!");
            double faltare = valor-recebido;
            Console.WriteLine("Faltam: "+faltare);
        }else if (recebido == valor)
        {
            Console.WriteLine("Pagamento exato, nao tem troco");
        }
        else
        {
            double troco = recebido-valor;
            Console.WriteLine("Troco: "+ troco);
        }
        Console.WriteLine("Deseja realizar outra compra? ");
        Console.WriteLine("[1] Sim");
        Console.WriteLine("[2] Não");
        opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
               continue;
            }else if(opcao == 2)
            {
                executando = false;

                Console.WriteLine("Caixa encerrado");
                
            }
            else
            {
                Console.WriteLine("Opcao invalida, digite novamente");
                continue;
            }
        
    }
    }
}