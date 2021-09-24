using MySql.Data.MySqlClient;
using System.Data;

namespace OrdemDeServico.DAO
{
    class ConexaoBancoDAO
    {

        public static MySqlConnection Conectar()
        {
            //string conexaoStr = @"Server=192.168.0.200;Database=aviso;Uid=aviso;Pwd=aviso*1344";
            string conexaoStr = @"Server=192.168.0.200;Database=ordemdeservico;Uid=ordem;Pwd=servico";
            MySqlConnection conexao = new MySqlConnection(conexaoStr);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(MySqlCommand comando)
        {
            MySqlConnection conexao = Conectar();
            comando.Connection = conexao;
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public static MySqlDataReader Selecionar(MySqlCommand comando)
        {
            MySqlConnection conexao = Conectar();
            MySqlDataReader dr;
            comando.Connection = conexao;
            dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
