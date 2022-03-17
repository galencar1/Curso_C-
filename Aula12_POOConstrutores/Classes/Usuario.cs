using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Cliente // Utilizando dois pontos : e o nome da classe declaramos uma HERANÇA
    {
 
        //Criando um construtor ( Basta criar um método com o mesmo nome da classe)
        //Construtor já passando parametros.

        public Usuario(string nome, string telefone, int id)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Id = id;
        }

        //Construtor sem parametros
        public Usuario() { }
        //Criar propriedades e métodos para minha classe Usuario
        public string Nome;
        public string Telefone;
        public int Id;

        public override void Gravar()

        {
            
            var usuarios = Usuario.LerUsuarios();
            Usuario u = new Usuario(this.Nome, this.Telefone, this.Id);
            usuarios.Add(u);

            if (File.Exists(CaminhoBase()))
            {
                StreamWriter r = new StreamWriter(CaminhoBase());
                string conteudo = "nome;telefone;id;";
                r.WriteLine(conteudo);
                foreach (Usuario c in usuarios)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.Id + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }

           
        }

        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>(); // Instanciando variavel que retorna os dados
            if (File.Exists(CaminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var ClienteArquivo = linha.Split(';');

                        //Utilizando construtor tradicional

                        var usuario = new Usuario(ClienteArquivo[0], ClienteArquivo[1], int.Parse(ClienteArquivo[2]));


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

                        usuarios.Add(usuario);



                    }
                }
            }
            return usuarios;
        }
        private static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_usuarios"];
        }

    }
}
