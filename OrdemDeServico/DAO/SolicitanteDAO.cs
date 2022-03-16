using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class SolicitanteDAO : ICrud<Solicitante>
    {
        public void Delete(Solicitante solcitante)
        {           
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM solicitante where Id=@Id";
            comando.Parameters.AddWithValue("Id", solcitante.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(Solicitante solicitante)
        {           
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO solicitante (Nome, Descricao, IdSetor) VALUES (@Nome, @Descricao, @IdSetor) ";
            comando.Parameters.AddWithValue("Nome", solicitante.Nome);
            comando.Parameters.AddWithValue("Descricao", solicitante.Descricao);
            comando.Parameters.AddWithValue("IdSetor", solicitante.SetorSolicitante.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(Solicitante solicitante)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE solicitante SET Nome=@Nome, Descricao=@Descricao, IdSetor=@IdSetor  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", solicitante.Id);
            comando.Parameters.AddWithValue("Nome", solicitante.Nome);
            comando.Parameters.AddWithValue("Descricao", solicitante.Descricao);
            comando.Parameters.AddWithValue("IdSetor", solicitante.SetorSolicitante.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Solicitante> SelectNome(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM solicitante WHERE Nome LIKE @Nome";
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
                    solicitante.SetorSolicitante.Id = Convert.ToInt16(dr["IdSetor"]);
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
        public Solicitante SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM solicitante WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Solicitante solicitante = new Solicitante();
            if (dr.HasRows)
            {
                dr.Read();
                solicitante.Id = Convert.ToInt32(dr["Id"]);
                solicitante.Nome = Convert.ToString(dr["Nome"]);
                solicitante.Descricao = Convert.ToString(dr["Descricao"]);
                solicitante.SetorSolicitante.Id = Convert.ToInt16(dr["IdSetor"]);                
            }
            else
            {
                solicitante = null;
            }
            dr.Close();
            return solicitante;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
