using System;

class Program
{
    static void Main()
    {
        string usuario = "admin";
        string senha = "1234";
        int tentativas = 3;


        bool logado = false;

        while (tentativas > 0)
        {
            Console.WriteLine("Informe o usuario: ");
            string user = Console.ReadLine();

            Console.WriteLine("Informe a senha: ");
            string pass = Console.ReadLine();
             
             
          if (user != usuario || pass != senha)
            {
                tentativas--;
                Console.WriteLine("Usuario ou senha incorretos");
                Console.WriteLine("Tentativas restantes: "+ tentativas);

                if(tentativas == 0)
                {
                Console.WriteLine("Acesso bloqueado.");                    
                }
        }

                else
                {
                logado = true;

                Console.WriteLine("Login realizado com sucesso");
                break;
                }
            }


            if (logado)
            {
                Console.WriteLine("[1] Perfil");
                Console.WriteLine("[2] Alterar senha");
                Console.WriteLine("[3] Sair");
                
            }
        
    }
}