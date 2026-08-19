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


            while (logado)

            {  
                int opcao =0;
                 
                Console.WriteLine("============ MENU ===========");
                Console.WriteLine("[1] Perfil");
                Console.WriteLine("[2] Alterar senha");
                Console.WriteLine("[3] Sair");

                opcao = Convert.ToInt32(Console.ReadLine());


            if (opcao == 1)
            {
                Console.WriteLine("======== PERFIL ========");
                Console.WriteLine("Usuario: "+ usuario);
                Console.WriteLine("Senha: "+ senha);
            }else if (opcao == 2)
            {
                Console.WriteLine("Digite a senha atual: ");
                string pw =Console.ReadLine();

                if (pw != senha)
                {
                    Console.WriteLine("Senha atual incorreta");
                    continue;
                }
                else
                {
                    Console.WriteLine("Digite a nova senha: ");
                    string novapss = Console.ReadLine();
                    
                   if (novapss.Length < 4)
                        {
                            Console.WriteLine("A nova senha precisa ter pelo menos 4 caracteres.");
                        }
                        else
                        {
                            senha = novapss;
                            Console.WriteLine("Senha alterada com sucesso!");
                        }


                }
            }else if (opcao == 3)
            {
                Console.WriteLine("Saindo do sistema...");
                 logado = false;
            }

                
            }
        
    }
}