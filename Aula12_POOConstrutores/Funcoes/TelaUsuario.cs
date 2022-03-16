using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("===============================CADASTRO DE USUARIO=======================");
            while (true)
            {
                string mensagem = "\n   Digite uma das opções abaixo:" +
                    "\n     0 - Sair do Cadastro" +
                    "\n     1 - Para Cadastrar Usuarios" +
                    "\n     2 - Listar Usuarios";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    //Grava novos clientes no DB

                    var usuario = new Usuario();
                    Console.WriteLine("Digite o Nome do Usuário: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do Usuário: ");
                    usuario.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o Id do Usuário: ");
                    usuario.Id = int.Parse(Console.ReadLine());
                    usuario.Gravar();
                    Console.WriteLine("Gravado com Sucesso.");

                }
                else
                {
                    // Retorna todos os clientes do DB
                    var usuarios = Usuario.LerUsuarios();
                    foreach (Usuario u in usuarios)
                    {
                        Console.WriteLine(u.Nome);
                        Console.WriteLine(u.Telefone);
                        Console.WriteLine(u.Id);
                    }

                }


                Console.ReadLine();
            }
        }
    }
}
