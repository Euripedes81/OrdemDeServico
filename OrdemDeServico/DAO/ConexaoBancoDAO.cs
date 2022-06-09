using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OrdemDeServico.DAO
{
    class ConexaoBancoDAO : IDisposable
    {

        public static MySqlConnection Conectar()
        {            
            string conexaoStr = @"Server=localhost;Database=ordemdeservico;Uid=ordem;Pwd=servico";
           
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
            comando.Connection = conexao;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public void Dispose()
        {
            Conectar().Close();
            Conectar().Dispose();
        }
    }
}
