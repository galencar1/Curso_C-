using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_C_Teste
{

    public class conexaoDB

    {
        public void efetuaConexao()
        {
            MySqlConnection conexao;
            /*
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string strSQL;
            */

            try
            {
                conexao = new MySqlConnection("Server=127.0.0.1;Database=teste_1;Uid=teste;Pwd=FrangoeFritas77;");
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                conexao=null;


            }
         }
    }
}
