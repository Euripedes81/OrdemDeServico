using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class SolicitanteDAO : ICrud
    {
        public void Delete(object obj)
        {
            Solicitante solcitante = obj as Solicitante;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Solicitante where Id=@Id";
            comando.Parameters.AddWithValue("Id", solcitante.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(object obj)
        {
            Solicitante solicitante = obj as Solicitante;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Solicitante (Nome, Descricao, IdSetor) VALUES (@Nome, @Descricao, @IdSetor) ";
            comando.Parameters.AddWithValue("Nome", solicitante.Nome);
            comando.Parameters.AddWithValue("Descricao", solicitante.Descricao);
            comando.Parameters.AddWithValue("IdSetor", solicitante.SetorSlc.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(object obj)
        {
            Solicitante solicitante = obj as Solicitante;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Solicitante SET Nome=@Nome, Descricao=@Descricao, IdSetor=@IdSetor  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", solicitante.Id);
            comando.Parameters.AddWithValue("Nome", solicitante.Nome);
            comando.Parameters.AddWithValue("Descricao", solicitante.Descricao);
            comando.Parameters.AddWithValue("IdSetor", solicitante.SetorSlc.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Solicitante> SelectNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Solicitante WHERE Nome LIKE @Nome";
            comando.Parameters.AddWithValue("Nome", "%" + nome + "%");
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            List<Solicitante> solicitantes = new List<Solicitante>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Solicitante solicitante = new Solicitante();
                    solicitante.Id = Convert.ToInt32(dr["Id"]);
                    solicitante.Nome = Convert.ToString(dr["Nome"]);
                    solicitante.Descricao = Convert.ToString(dr["Descricao"]);
                    solicitante.SetorSlc.Id = Convert.ToInt16(dr["IdSetor"]);
                    solicitantes.Add(solicitante);
                }
            }
            else
            {
                solicitantes = null;
            }
            dr.Close();
            return solicitantes;
        }
    }
}
