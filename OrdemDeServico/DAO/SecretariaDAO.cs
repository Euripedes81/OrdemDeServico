using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class SecretariaDAO : ICrud<Secretaria>
    {
        public void Delete(Secretaria secretaria)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM secretaria where Id=@Id";
            comando.Parameters.AddWithValue("Id", secretaria.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(Secretaria secretaria)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO secretaria (Nome, Descricao, Telefone) VALUES (@Nome, @Descricao, @Telefone) ";
            comando.Parameters.AddWithValue("Nome", secretaria.Nome);
            comando.Parameters.AddWithValue("Descricao", secretaria.Descricao);
            comando.Parameters.AddWithValue("Telefone", secretaria.Telefone);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(Secretaria secretaria)
        {           
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE secretaria SET Nome=@Nome, Descricao=@Descricao, Telefone=@Telefone  WHERE Id=@Id";
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
            comando.CommandText = "SELECT * FROM secretaria WHERE Nome LIKE @Nome";
            comando.Parameters.AddWithValue("Nome", "%" + nome + "%");
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
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
               
                return secretarias;
            }
        }
        public Secretaria SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM secretaria WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
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
}
