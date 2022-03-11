using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudForm_Teste
{
    public class CadastrarCliente
    {
        Conexao connect = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        public string mensagem = "";
        //Construtor
        public CadastrarCliente(String nome, String email, String telefone)
        {
            //Comando SQL - INSERT -- MySql Command
            comando.CommandText = "INSERT INTO clientes(nome_cliente,email_cliente,telefone_cliente) VALUES (@NOME, @EMAIL, @TELEFONE)";
            //Parametros
            comando.Parameters.AddWithValue("@NOME",nome);
            comando.Parameters.AddWithValue("@EMAIL", email);
            comando.Parameters.AddWithValue("@TELEFONE", telefone);
            //conectar com o DB -- Puxar a Classe Conexão
            try
            {
                comando.Connection = connect.conectar();
                //executar o comando
                comando.ExecuteNonQuery();
                //desconectar
                connect.desconectar();

                //Mostrar mensagem de erro ou sucesso -- Variavel
                this.mensagem = "CADASTRADO COM SUCESSO!!";
            }
            catch (MySqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados.";
                
            }
            
            
        }
    }
}
