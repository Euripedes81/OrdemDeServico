using OrdemDeServico.DAO;
using OrdemDeServico.Model;

namespace OrdemDeServico.Helpers
{
    public class InsertData
    {
        public static void Inserir(Secretaria secretaria)
        {
            ICrud<Secretaria> secretariaDAO = new SecretariaDAO();
            if (secretaria.Id == 0)
            {
                secretariaDAO.Insert(secretaria);
            }
            else
            {
                secretariaDAO.Update(secretaria);
            }
        }
        public static void Inserir(Setor setor)
        {
            ICrud<Setor> setorDAO = new SetorDAO();
            if (setor.Id == 0)
            {
                setorDAO.Insert(setor);
            }
            else
            {
                setorDAO.Update(setor);
            }
        }
        public static void Inserir(Solicitante solicitante)
        {
            ICrud<Solicitante> solicitanteDAO = new SolicitanteDAO();
            if (solicitante.Id == 0)
            {
                solicitanteDAO.Insert(solicitante);
            }
            else
            {
                solicitanteDAO.Update(solicitante);
            }
        }

        public static void Inserir(Maquina maquina)
        {
            ICrud<Maquina> maquinaDAO = new MaquinaDAO();
            if (maquina.Id == 0)
            {
                maquinaDAO.Insert(maquina);
            }
            else
            {
                maquinaDAO.Update(maquina);
            }
        }
        public static void Inserir(OrdemServico ordemServico)
        {
            ICrud<OrdemServico> ordemServicoDAO = new OrdemServicoDAO();
            if (ordemServico.Id == 0)
            {
                ordemServicoDAO.Insert(ordemServico);
            }
            else
            {
                ordemServicoDAO.Update(ordemServico);
            }
        }

        public static void Inserir(Atendente atendente)
        {
            ICrud<Atendente> atendenteDAO = new AtendenteDAO();
            if (atendente.Id == 0)
            {
                atendenteDAO.Insert(atendente);
            }
            else
            {
                atendenteDAO.Update(atendente);
            }
        }
    }
}
