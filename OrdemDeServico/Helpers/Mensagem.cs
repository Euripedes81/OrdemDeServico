using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Helpers
{
    class Mensagem
    {
        public static void SecretariaMsgExcluir()
        {
            MessageBox.Show("Você não pode excluir uma secretaria que esteja vinculado com algum setor", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
        public static void SetorMsgExcluir()
        {
            MessageBox.Show("Você não pode excluir um Setor que esteja vinculado com alguma máquina ou solicitante!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void AtendenteMsgExcluir()
        {
            MessageBox.Show("Você não pode excluir um usuário que esteja vinculado com alguma O.S!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SolicitanteMsgExcluir()
        {
            MessageBox.Show("Você não pode excluir um Solicitante que esteja vinculado com alguma O.S!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MaquinaMsgExcluir()
        {
            MessageBox.Show("Você não pode excluir uma Máquina que esteja vinculado com alguma O.S!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SecretariaMsgAdicionar()
        {
            MessageBox.Show("Este nome de Secretaria já está em uso!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SetorMsgAdicionar()
        {
            MessageBox.Show("Este nome de Setor já está em uso!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void AtendenteMsgAdicionar()
        {
            MessageBox.Show("Este nome de Usuário já está em uso!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SolicitanteMsgAdicionar()
        {
            MessageBox.Show("Este nome de Solicitante já está em uso!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MaquinaMsgAdicionar()
        {
            MessageBox.Show("Este número de Patrimônio já está em uso!", "",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
