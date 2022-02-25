using Classes;
using Tela;

namespace ProgramacaoFuncional
{
    class program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();
            
            
            var clientes = Cliente.LerClientes(); // Retorna todos os clientes do DB
            foreach(Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.Id);
            }
            Console.ReadLine();
            

            //Grava novos clientes no DB
            /*
            var cliente = new Cliente();
            cliente.Nome = "Eleven";
            cliente.Telefone = "2222-2222";
            cliente.Id = 3;
            cliente.Gravar();
            */
            
            //Grava novos clientes no DB
            /*
            var cliente2 = new Cliente();
            cliente2.Nome = "Schtarden";
            cliente2.Telefone = "3333-3333";
            cliente2.Id = 4;
            cliente2.Gravar();
            */

            var cliente3 = new Cliente();
            cliente3.Nome = "Senju Hashirama";
            cliente3.Telefone = "4444-4444";
            cliente3.Id = 5;
            cliente3.Gravar();
            
        }
    }
}