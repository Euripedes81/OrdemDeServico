using OrdemDeServico.DAO;
using OrdemDeServico.Model;

namespace OrdemDeServico.Helpers
{
    class CrudHelper
    {
        public static void Inserir(Secretaria secretaria)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            if (secretaria.Id == 0)
            {
                secretariaDAO.Insert(secretaria);
            }
            else
            {
                secretariaDAO.Update(secretaria);
            }
        }
        public static void Excluir(Secretaria secretaria)
        {
            SecretariaDAO secretariaDAO = new SecretariaDAO();
            secretariaDAO.Delete(secretaria);
        }
        public static void Inserir(Setor setor)
        {
            SetorDAO setorDAO = new SetorDAO();
            if (setor.Id == 0)
            {
                setorDAO.Insert(setor);
            }
            else
            {
                setorDAO.Update(setor);
            }
        }
        public static void Excluir(Setor setor)
        {
            SetorDAO setorDAO = new SetorDAO();
            setorDAO.Delete(setor);
        }
        public static void Inserir(Solicitante solicitante)
        {
            SolicitanteDAO solicitanteDAO = new SolicitanteDAO();
            if (solicitante.Id == 0)
            {
                solicitanteDAO.Insert(solicitante);
            }
            else
            {
                solicitanteDAO.Update(solicitante);
            }
        }
        public static void Excluir(Solicitante solicitante)
        {
            SolicitanteDAO solicitanteDAO = new SolicitanteDAO();
            solicitanteDAO.Delete(solicitante);
        }
        public static void Inserir(Maquina maquina)
        {
            MaquinaDAO maquinaDAO = new MaquinaDAO();
            if (maquina.Id == 0)
            {
                maquinaDAO.Insert(maquina);
            }
            else
            {
                maquinaDAO.Update(maquina);
            }
        }
        public static void Excluir(Maquina solicitante)
        {
            MaquinaDAO maquinaDAO = new MaquinaDAO();
            maquinaDAO.Delete(solicitante);
        }
        public static void Inserir(OrdemServico ordemServico)
        {
            OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();
            if (ordemServico.Id == 0)
            {
                ordemServicoDAO.Insert(ordemServico);
            }
            else
            {
                ordemServicoDAO.Update(ordemServico);
            }
        }
        public static void Excluir(OrdemServico ordemServico)
        {
            OrdemServicoDAO ordemServicoDAO = new OrdemServicoDAO();
            ordemServicoDAO.Delete(ordemServico);
        }
    }
}
