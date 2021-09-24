using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class SecretariaDAO : ICrud
    {
        public void Delete(object obj)
        {
            Secretaria secretaria = obj as Secretaria;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Secretaria where Id=@Id";
            comando.Parameters.AddWithValue("Id", secretaria.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(object obj)
        {
            Secretaria secretaria = obj as Secretaria;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Secretaria (Nome, Descricao, Telefone) VALUES (@Nome, @Descricao, @Telefone) ";
            comando.Parameters.AddWithValue("Nome", secretaria.Nome);
            comando.Parameters.AddWithValue("Descricao", secretaria.Descricao);
            comando.Parameters.AddWithValue("Telefone", secretaria.Telefone);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(object obj)
        {
            Secretaria secretaria = obj as Secretaria;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Secretaria SET Nome=@Nome, Descricao=@Descricao, Telefone=@Telefone  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", secretaria.Id);
            comando.Parameters.AddWithValue("Nome", secretaria.Nome);
            comando.Parameters.AddWithValue("Descricao", secretaria.Descricao);
            comando.Parameters.AddWithValue("Telefone", secretaria.Telefone);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Secretaria> SelectNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Secretaria WHERE Nome LIKE @Nome";
            comando.Parameters.AddWithValue("Nome", "%" + nome + "%");
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            List<Secretaria> secretarias = new List<Secretaria>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Secretaria secretaria = new Secretaria();
                    secretaria.Id = Convert.ToInt32(dr["Id"]);
                    secretaria.Nome = Convert.ToString(dr["Nome"]);
                    secretaria.Descricao = Convert.ToString(dr["Descricao"]);
                    secretaria.Telefone = Convert.ToString(dr["Telefone"]);
                    secretarias.Add(secretaria);
                }
            }
            else
            {

            }
            dr.Close();
            return secretarias;
        }
        public Secretaria SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Secretaria WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Secretaria secretaria = new Secretaria();
            if (dr.HasRows)
            {
                dr.Read();
                secretaria.Id = Convert.ToInt32(dr["Id"]);
                secretaria.Nome = Convert.ToString(dr["Nome"]);
                secretaria.Descricao = Convert.ToString(dr["Descricao"]);
                secretaria.Telefone = Convert.ToString(dr["Telefone"]);
            }
            else
            {
                secretaria = null;
            }
            return secretaria;
        }
    }
}
