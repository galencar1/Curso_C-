using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Funcoes
{
    internal class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("===============================CADASTRO DE CLIENTE=======================");
            while (true)
            {
                string mensagem = "\n   Digite uma das opções abaixo:" +
                    "\n     0 - Sair do Cadastro" +
                    "\n     1 - Para Cadastrar Clientes" +
                    "\n     2 - Listar Clientes" ;
                
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    //Grava novos clientes no DB

                    var cliente = new Cliente();
                    cliente.Nome = Console.ReadLine();
                    cliente.Telefone = Console.ReadLine();
                    cliente.Id = int.Parse(Console.ReadLine());
                    cliente.Gravar();

                }
                else
                {
                    // Retorna todos os clientes do DB
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.Id);
                    }

                }


                Console.ReadLine();

               



                //Grava novos clientes no DB

                var cliente2 = new Cliente();
                cliente2.Nome = "Schtarden";
                cliente2.Telefone = "3333-3333";
                cliente2.Id = 4;
                cliente2.Gravar();

            }
            
        }
    }
}
