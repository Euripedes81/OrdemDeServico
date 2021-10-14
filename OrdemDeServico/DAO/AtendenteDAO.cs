using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class AtendenteDAO : ICrud
    {
        public void Delete(object obj)
        {
            Atendente atendente = obj as Atendente;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Atendente where Id=@Id";
            comando.Parameters.AddWithValue("Id", atendente.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(object obj)
        {
            Atendente atendente = obj as Atendente;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Atendente (Usuario, Nome, Senha) VALUES (@Usuario, @Nome, md5(@Senha))";
            comando.Parameters.AddWithValue("Usuario", atendente.Usuario);
            comando.Parameters.AddWithValue("Nome", atendente.Nome);
            comando.Parameters.AddWithValue("Senha", atendente.Senha);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(object obj)
        {
            Atendente atendente = obj as Atendente;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Atendente SET Senha=MD5(@Senha)  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", atendente.Id);
            comando.Parameters.AddWithValue("Senha", atendente.Senha);            
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Atendente> SelectNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendente WHERE Nome LIKE @Nome";
            comando.Parameters.AddWithValue("Nome", "%" + nome + "%");
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            List<Atendente> atendentes = new List<Atendente>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Atendente atendente = new Atendente();
                    atendente.Id = Convert.ToInt32(dr["Id"]);
                    atendente.Usuario = Convert.ToString(dr["Usuario"]);
                    atendente.Nome = Convert.ToString(dr["Nome"]);
                    atendente.Senha = Convert.ToString(dr["Senha"]);
                    atendentes.Add(atendente);
                }
            }
            else
            {
                atendentes = null;
            }
            dr.Close();
            return atendentes;
        }
        public Atendente SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendente WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Atendente atendente = new Atendente();
            if (dr.HasRows)
            {
                dr.Read();
                atendente.Id = Convert.ToInt32(dr["Id"]);
                atendente.Usuario = Convert.ToString(dr["Usuario"]);
                atendente.Nome = Convert.ToString(dr["Nome"]);
                atendente.Senha = Convert.ToString(dr["Senha"]);
            }
            else
            {
                atendente = null;
            }
            dr.Close();
            return atendente;
        }
        public Atendente SelectUsuarioExiste(string usuario)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendente WHERE Usuario=@Usuario";
            comando.Parameters.AddWithValue("Usuario", usuario);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Atendente atendente = new Atendente();
            if (dr.HasRows)
            {
                dr.Read();
                atendente.Id = Convert.ToInt32(dr["Id"]);
                atendente.Usuario = Convert.ToString(dr["Usuario"]);
                atendente.Nome = Convert.ToString(dr["Nome"]);
                atendente.Senha = Convert.ToString(dr["Senha"]);
            }
            else
            {
                atendente = null;
            }
            dr.Close();
            return atendente;

        }
        public bool SelectUsuarioSenha(int id, string senha)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Atendente WHERE Id=@Id and Senha=md5(@Senha)";
            comando.Parameters.AddWithValue("Id", id);
            comando.Parameters.AddWithValue("Senha", senha);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Atendente atendente = new Atendente();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
