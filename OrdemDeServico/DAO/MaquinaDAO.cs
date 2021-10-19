using MySql.Data.MySqlClient;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace OrdemDeServico.DAO
{
    class MaquinaDAO : ICrud<Maquina>
    {
        public void Delete(Maquina maquina)
        {          
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM maquina where Id=@Id";
            comando.Parameters.AddWithValue("Id", maquina.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Insert(Maquina maquina)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO maquina (Patrimonio, Tipo,Descricao, IdSetor) VALUES (@Patrimonio, @Tipo, @Descricao, @IdSetor) ";
            comando.Parameters.AddWithValue("Patrimonio", maquina.Patrimonio);
            comando.Parameters.AddWithValue("Tipo", maquina.Tipo);
            comando.Parameters.AddWithValue("Descricao", maquina.Descricao);
            comando.Parameters.AddWithValue("IdSetor", maquina.SetorMqn.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public void Update(Maquina maquina)
        {            
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE maquina SET Patrimonio=@Patrimonio, Tipo=@Tipo, Descricao=@Descricao, IdSetor=@IdSetor  WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", maquina.Id);
            comando.Parameters.AddWithValue("Patrimonio", maquina.Patrimonio);
            comando.Parameters.AddWithValue("Tipo", maquina.Tipo);
            comando.Parameters.AddWithValue("Descricao", maquina.Descricao);
            comando.Parameters.AddWithValue("IdSetor", maquina.SetorMqn.Id);
            ConexaoBancoDAO.CRUD(comando);
        }

        public List<Maquina> SelectNome(int Patrimonio)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM maquina WHERE Patrimonio like @Patrimonio";
            comando.Parameters.AddWithValue("Patrimonio", Patrimonio + "%");
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            List<Maquina> maquinas = new List<Maquina>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Maquina maquina = new Maquina();
                    maquina.Id = Convert.ToInt32(dr["Id"]);
                    maquina.Patrimonio = Convert.ToInt32(dr["Patrimonio"]);
                    maquina.Tipo = Convert.ToString(dr["Tipo"]);
                    maquina.Descricao = Convert.ToString(dr["Descricao"]);
                    maquina.SetorMqn.Id = Convert.ToInt16(dr["IdSetor"]);
                    maquinas.Add(maquina);
                }
            }
            else
            {
                maquinas = null;
            }
            dr.Close();
            return maquinas;
        }
        public Maquina SelectId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM maquina WHERE Id=@Id";
            comando.Parameters.AddWithValue("Id", id);
            MySqlDataReader dr = ConexaoBancoDAO.Selecionar(comando);
            Maquina maquina = new Maquina();
            if (dr.HasRows)
            {
                dr.Read();
                maquina.Id = Convert.ToInt32(dr["Id"]);
                maquina.Patrimonio = Convert.ToInt32(dr["Patrimonio"]);
                maquina.Tipo = Convert.ToString(dr["Tipo"]);
                maquina.Descricao = Convert.ToString(dr["Descricao"]);
                maquina.SetorMqn.Id = Convert.ToInt16(dr["IdSetor"]);
            }
            else
            {
                maquina = null;
            }
            dr.Close();
            return maquina;
        }
    }
}
