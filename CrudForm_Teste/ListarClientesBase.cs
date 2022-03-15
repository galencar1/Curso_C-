using MySql.Data.MySqlClient;
using System.Data;

namespace CrudForm_Teste
{
    public class ListarClientesBase
    {
        //Construtor
        public static DataTable GetClientes(bool dados)
        {

            Conexao connect = new Conexao();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            DataGridView DataGridView1 = new DataGridView();
    }
}