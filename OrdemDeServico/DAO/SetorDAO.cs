using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class SetorDAO : ICrud
    {
        public void Delete(object obj)
        {
            Setor setor = obj as Setor;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Setor where Id=@Id";
            comando.Parameters.AddWithValue("Id", setor.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(object obj)
        {
            Setor setor = obj as Setor;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Setor (Nome, Descricao, IdSecretaria) VALUES (@Nome, @Descricao, @IdSecretaria) ";
            comando.Parameters.AddWithValue("Nome", setor.Nome);
            comando.Parameters.AddWithValue("Descricao", setor.Descricao);
            comando.Parameters.AddWithValue("IdSecretaria", setor.SecretariaStr.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(object obj)
        {
            Setor setor = obj as Setor;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Setor SET Nome=@Nome, Descricao=@Descricao, IdSecretaria=@IdSecretaria  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", setor.Id);
            comando.Parameters.AddWithValue("Nome", setor.Nome);
            comando.Parameters.AddWithValue("Descricao", setor.Descricao);
            comando.Parameters.AddWithValue("IdSecretaria", setor.SecretariaStr.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Setor> SelectNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Setor WHERE Nome LIKE @Nome";
            comando.Parameters.AddWithValue("Nome", "%" + nome + "%");
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            List<Setor> setores = new List<Setor>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Setor setor = new Setor();
                    setor.Id = Convert.ToInt32(dr["Id"]);
                    setor.Nome = Convert.ToString(dr["Nome"]);
                    setor.Descricao = Convert.ToString(dr["Descricao"]);
                    setor.SecretariaStr.Id = Convert.ToInt16(dr["IdSecretaria"]);
                    setores.Add(setor);
                }
            }
            else
            {
                setores = null;
            }
            dr.Close();
            return setores;
        }
        public Setor SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Setor WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Setor setor = new Setor();
            if (dr.HasRows)
            {
                dr.Read();                
                setor.Id = Convert.ToInt32(dr["Id"]);
                setor.Nome = Convert.ToString(dr["Nome"]);
                setor.Descricao = Convert.ToString(dr["Descricao"]);
                setor.SecretariaStr.Id = Convert.ToInt16(dr["IdSecretaria"]);                
            }
            else
            {
                setor = null;
            }
            dr.Close();
            return setor;
        }
    }
}
