using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudForm_Teste
{
    public class Conexao
    {
        //Variáveis
        MySqlConnection conn = new MySqlConnection();

        //Construtor
        public Conexao()
        {
            conn.ConnectionString = "Server=127.0.0.1;Database=teste_1;Uid=teste;Pwd=FrangoeFritas77;";
        }
        
        //Conectar no DB
        public MySqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }
        //Desconectar DB
        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }
}
