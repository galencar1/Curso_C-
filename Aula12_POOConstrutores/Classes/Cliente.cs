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

        //Criando um construtor ( Basta criar um método com o mesmo nome da classe)
        //Construtor já passando parametros.
        
        public Cliente(string nome, string telefone, int id)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Id = id;
        }

        //Construtor sem parametros
        public Cliente() { }
        



        //Criar propriedades e métodos para minha classe Cliente
        public string Nome;
        public string Telefone;
        public int Id;

        //Criar método para gravar dados no banco de dados
        //Método não estático, utilizado para um cliente (Um DADO)
        public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);

            if (File.Exists(CaminhoBaseClientes()))
            {
                StreamWriter r = new StreamWriter(CaminhoBaseClientes());
                string conteudo = "nome;telefone;id;";
                r.WriteLine(conteudo);
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Id + ";";
                    r.WriteLine(linha);
                }
                r.Close();
                
            }
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

                        //Utilizando construtor tradicional

                        var cliente = new Cliente(ClienteArquivo[0], ClienteArquivo[1], int.Parse(ClienteArquivo[2]));
                        
                        
                        //Utilizando construtor automatico com chaves para ler valores.
                        /*
                        var cliente = new Cliente { 
                            Nome = ClienteArquivo[0], 
                            Telefone = ClienteArquivo[1], 
                            Id = int.Parse(ClienteArquivo[2])
                        };
                        */



                        //Utilizando método tradicional para ler os valores
                        /*
                        var cliente = new Cliente();
                        cliente.Nome = ClienteArquivo[0];
                        cliente.Telefone = ClienteArquivo[1];
                        cliente.Id = int.Parse(ClienteArquivo[2]);
                        */

                        clientes.Add(cliente);



                    }
                }
            }
            return clientes;
        }
    }
}