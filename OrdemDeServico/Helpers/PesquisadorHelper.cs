using OrdemDeServico.DAO;
using OrdemDeServico.Model;
using System.Collections.Generic;

namespace OrdemDeServico.Helpers
{
    class PesquisadorHelper
    {
        public static List<Secretaria> PesquisarSecretaria(string nome)
        {
            List<Secretaria> secretarias;
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            secretarias = secretariaDAO.SelectNome(nome);
            return secretarias;
        }
        public static Secretaria PesquisarSecretaria(int id)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            Secretaria secretaria;
            secretaria = secretariaDAO.SelectId(id);
            return secretaria;
        }
        public static List<Setor> PesquisarSetor(string nome)
        {
            List<Setor> setores;
            SetorDAO setorDAO = new SetorDAO();
            setores = setorDAO.SelectNome(nome);
            return setores;
        }
        public static Setor PesquisarSetor(int id)
        {
            SetorDAO setorDAO = new SetorDAO();
            Setor setor;
            setor = setorDAO.SelectId(id);
            return setor;
        }       
        public static List<Solicitante> PesquisarSolicitante(string nome)
        {
            List<Solicitante> solicitante;
            SolicitanteDAO solicitanteDAO = new SolicitanteDAO();
            solicitante = solicitanteDAO.SelectNome(nome);
            return solicitante;
        }
        public static List<Maquina> PesquisarMaquina(int patrimonio )
        {
            List<Maquina> maquina;
            MaquinaDAO maquinaDAO = new MaquinaDAO();
            maquina = maquinaDAO.SelectNome(patrimonio);
            return maquina;
        }
    }
}
