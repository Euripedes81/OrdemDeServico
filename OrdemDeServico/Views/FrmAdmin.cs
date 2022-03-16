using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using OrdemDeServico.Views.Usuario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views
{
    public partial class FrmAdmin : Form
    {
        Atendente atendente = new Atendente();
        List<Atendente> atendentes = new List<Atendente>();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, atendentes);
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddUsuario frmAddUsuario = new FrmAddUsuario();
            frmAddUsuario.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if(HandlerDataGridView.ObterLinhaDgv(dgv, atendente))
            {
                FrmAlteraSenha frmAlteraSenha = new FrmAlteraSenha(atendente);
                frmAlteraSenha.ShowDialog();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (HandlerDataGridView.ObterLinhaDgv(dgv, atendente))
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    if (atendente.Id != 1)
                    {
                        try
                        {
                            DeleteData.Excluir(atendente);
                            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, atendentes);
                        }
                        catch (Exception )
                        {
                            MensagemEntidades.AtendenteMsgExcluir();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O usuário admin não pode ser excluído!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
