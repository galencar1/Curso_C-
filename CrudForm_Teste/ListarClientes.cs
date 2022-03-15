using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudForm_Teste
{
    public class ListarClientes
    {

        Conexao connect = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataGridView DataGridView1 = new DataGridView();
        public string mensagem = "";



        //Construtor
        public DataTable GetClientes(bool dados)
        {
            //Comando SQL - SELECT
            comando.CommandText = "SELECT * FROM clientes";
            //Conectar com o DB - Puxar a classe conexão - Utilizar tryCatch
            try
            {
                comando.Connection = connect.conectar();
                
                //DataAdapter
                da = new MySqlDataAdapter(comando);
                //DataTable
                da.Fill(dt);
                //exibindo resultados no DataGridView
                DataGridView1.DataSource = dt;
                
               
                //desconectar
                connect.desconectar();

                //Exibir mensagem de erro ou sucesso
                this.mensagem = "DADOS CARREGADOS COM SUCESSO";
                 
            }
            catch (MySqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados!" + e;

            }

            return dt;
        }
    }
}
