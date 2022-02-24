using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        //Criar propriedades e métodos para minha classe Cliente
        public string Nome;
        public string Telefone;
        public int Id;

        //Criar método para gravar dados no banco de dados
        //Método não estático, utilizado para um cliente (Um DADO)
        public void Gravar()
        {
            // TODO implementar
        }

        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_clientes"];
        }

        //Criar método para ler os dados do banco de dados
        //Método estático é usado para realizar uma ação com vários clientes(VÁRIOS DADOS).
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>(); // Instanciando variavel que retorna os dados
            if (File.Exists(CaminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var ClienteArquivo = linha.Split(';');

                        var cliente = new Cliente();
                        cliente.Nome = ClienteArquivo[0];
                        cliente.Telefone = ClienteArquivo[1];
                        cliente.Id = int.Parse(ClienteArquivo[2]);

                        clientes.Add(cliente);
                        

                        
                    }
                }
            }
            return clientes;
        }
    }
}
