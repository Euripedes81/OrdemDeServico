using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class OrdemServicoDAO : ICrud<OrdemServico>
    {
        public void Delete(OrdemServico ordemDeServico)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM ordemdeServico where Id=@Id";
            comando.Parameters.AddWithValue("Id", ordemDeServico.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(OrdemServico ordemServico)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO ordemdeservico (IdSolicitante, IdMaquina, IdSetor, Diagnostico, DataAbertura, Solucao, DataFechamento, Observacao, IdAtendente)" +
                " VALUES (@IdSolicitante, @IdMaquina, @IdSetor, @Diagnostico, @DataAbertura, @Solucao, @DataFechamento, @Observacao, @IdAtendente)";
            comando.Parameters.AddWithValue("IdSolicitante", ordemServico.SolicitanteOs.Id);
            comando.Parameters.AddWithValue("IdMaquina", ordemServico.MaquinaOs.Id);
            comando.Parameters.AddWithValue("IdSetor", ordemServico.SetorOs.Id);
            comando.Parameters.AddWithValue("Diagnostico", ordemServico.Diagnostico);
            comando.Parameters.AddWithValue("DataAbertura", ordemServico.DataAbertura);
            comando.Parameters.AddWithValue("Solucao", ordemServico.Solucao);
            comando.Parameters.AddWithValue("DataFechamento", ordemServico.DataFechamento);
            comando.Parameters.AddWithValue("Observacao", ordemServico.Observacao);
            comando.Parameters.AddWithValue("IdAtendente", ordemServico.AtendenteOs.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(OrdemServico ordemServico)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE ordemdeservico SET Solucao=@Solucao, DataFechamento=@DataFechamento, Observacao=@Observacao, IdAtendente=@IdAtendente  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", ordemServico.Id);
            comando.Parameters.AddWithValue("Solucao", ordemServico.Solucao);
            comando.Parameters.AddWithValue("DataFechamento", ordemServico.DataFechamento);
            comando.Parameters.AddWithValue("Observacao", ordemServico.Observacao);
            comando.Parameters.AddWithValue("IdAtendente", ordemServico.AtendenteOs.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<OrdemServico> SelectListaId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ordemdeservico WHERE Id like @Id";
            comando.Parameters.AddWithValue("Id", id + "%");
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
                List<OrdemServico> ordemServicos = new List<OrdemServico>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OrdemServico ordemServico = new OrdemServico();
                        ordemServico.Id = Convert.ToInt32(dr["Id"]);
                        ordemServico.SolicitanteOs.Id = Convert.ToInt32(dr["IdSolicitante"]);
                        ordemServico.MaquinaOs.Id = Convert.ToInt32(dr["IdMaquina"]);
                        ordemServico.SetorOs.Id = Convert.ToInt32(dr["IdSetor"]);
                        ordemServico.DataAbertura = Convert.ToDateTime(dr["DataAbertura"]);
                        ordemServico.Diagnostico = Convert.ToString(dr["Diagnostico"]);
                        ordemServico.DataFechamento = Convert.ToDateTime(dr["DataFechamento"]);
                        ordemServico.Solucao = Convert.ToString(dr["Solucao"]);
                        ordemServico.Observacao = Convert.ToString(dr["Observacao"]);
                        ordemServico.AtendenteOs.Id = Convert.ToInt32(dr["IdAtendente"]);
                        ordemServicos.Add(ordemServico);
                    }
                }
                else
                {
                    ordemServicos = null;
                }
               
                return ordemServicos;
            }
        }
        public List<OrdemServico> SelectIdSolicitante(int idSolicitante)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ordemdeservico WHERE IdSolicitante=@IdSolicitante";
            comando.Parameters.AddWithValue("IdSolicitante", idSolicitante);
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
                List<OrdemServico> ordemServicos = new List<OrdemServico>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OrdemServico ordemServico = new OrdemServico();
                        ordemServico.Id = Convert.ToInt32(dr["Id"]);
                        ordemServico.SolicitanteOs.Id = Convert.ToInt32(dr["IdSolicitante"]);
                        ordemServico.MaquinaOs.Id = Convert.ToInt32(dr["IdMaquina"]);
                        ordemServico.SetorOs.Id = Convert.ToInt32(dr["IdSetor"]);
                        ordemServico.Diagnostico = Convert.ToString(dr["Diagnostico"]);
                        ordemServico.DataAbertura = Convert.ToDateTime(dr["DataAbertura"]);
                        ordemServico.Solucao = Convert.ToString(dr["Solucao"]);
                        ordemServico.DataFechamento = Convert.ToDateTime(dr["DataFechamento"]);
                        ordemServico.Observacao = Convert.ToString(dr["Observacao"]);
                        ordemServico.AtendenteOs.Id = Convert.ToInt32(dr["IdAtendente"]);
                        ordemServicos.Add(ordemServico);
                    }
                }
                else
                {
                    ordemServicos = null;
                }
               
                return ordemServicos;
            }
        }
        public List<OrdemServico> SelectIdSolicitante(int idSolicitante, DateTime dtInicio, DateTime dtFim)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ordemdeservico WHERE IdSolicitante=@IdSolicitante and DataFechamento >= @dtInicio " +
                "and DataFechamento <= @dtFim";
            comando.Parameters.AddWithValue("IdSolicitante", idSolicitante);
            comando.Parameters.AddWithValue("dtInicio", dtInicio);
            comando.Parameters.AddWithValue("dtFim", dtFim);
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
                List<OrdemServico> ordemServicos = new List<OrdemServico>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OrdemServico ordemServico = new OrdemServico();
                        ordemServico.Id = Convert.ToInt32(dr["Id"]);
                        ordemServico.SolicitanteOs.Id = Convert.ToInt32(dr["IdSolicitante"]);
                        ordemServico.MaquinaOs.Id = Convert.ToInt32(dr["IdMaquina"]);
                        ordemServico.SetorOs.Id = Convert.ToInt32(dr["IdSetor"]);
                        ordemServico.Diagnostico = Convert.ToString(dr["Diagnostico"]);
                        ordemServico.DataAbertura = Convert.ToDateTime(dr["DataAbertura"]);
                        ordemServico.Solucao = Convert.ToString(dr["Solucao"]);
                        ordemServico.DataFechamento = Convert.ToDateTime(dr["DataFechamento"]);
                        ordemServico.Observacao = Convert.ToString(dr["Observacao"]);
                        ordemServico.AtendenteOs.Id = Convert.ToInt32(dr["IdAtendente"]);
                        ordemServicos.Add(ordemServico);
                    }
                }
                else
                {
                    ordemServicos = null;
                }
               
                return ordemServicos;
            }
        }


        public OrdemServico SelectId(int numeroOs)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ordemdeservico WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", numeroOs);
            using (MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando))
            {
                OrdemServico ordemServico = new OrdemServico();
                if (dr.HasRows)
                {
                    dr.Read();
                    ordemServico.Id = Convert.ToInt32(dr["Id"]);
                    ordemServico.SolicitanteOs.Id = Convert.ToInt32(dr["IdSolicitante"]);
                    ordemServico.MaquinaOs.Id = Convert.ToInt32(dr["IdMaquina"]);
                    ordemServico.SetorOs.Id = Convert.ToInt32(dr["IdSetor"]);
                    ordemServico.Diagnostico = Convert.ToString(dr["Diagnostico"]);
                    ordemServico.DataAbertura = Convert.ToDateTime(dr["DataAbertura"]);
                    ordemServico.Solucao = Convert.ToString(dr["Solucao"]);
                    ordemServico.DataFechamento = Convert.ToDateTime(dr["DataFechamento"]);
                    ordemServico.Observacao = Convert.ToString(dr["Observacao"]);
                    ordemServico.AtendenteOs.Id = Convert.ToInt32(dr["IdAtendente"]);
                }
                else
                {
                    ordemServico = null;
                }
               
                return ordemServico;
            }
        }

    }
}
