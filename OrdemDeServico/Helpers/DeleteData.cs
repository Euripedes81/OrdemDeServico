using OrdemDeServico.DAO;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeServico.Helpers
{
    public class DeleteData
    {
        public static void Excluir(Secretaria secretaria)
        {
            ICrud<Secretaria> secretariaDAO = new SecretariaDAO();
            secretariaDAO.Delete(secretaria);
        }

        public static void Excluir(Setor setor)
        {
            ICrud<Setor> setorDAO = new SetorDAO();
            setorDAO.Delete(setor);
        }

        public static void Excluir(Solicitante solicitante)
        {
            ICrud<Solicitante> solicitanteDAO = new SolicitanteDAO();
            solicitanteDAO.Delete(solicitante);
        }

        public static void Excluir(Maquina solicitante)
        {
            ICrud<Maquina> maquinaDAO = new MaquinaDAO();
            maquinaDAO.Delete(solicitante);
        }

        public static void Excluir(OrdemServico ordemServico)
        {
            ICrud<OrdemServico> ordemServicoDAO = new OrdemServicoDAO();
            ordemServicoDAO.Delete(ordemServico);
        }

        public static void Excluir(Atendente atendente)
        {
            ICrud<Atendente> atendenteDAO = new AtendenteDAO();
            atendenteDAO.Delete(atendente);
        }
    }
}
