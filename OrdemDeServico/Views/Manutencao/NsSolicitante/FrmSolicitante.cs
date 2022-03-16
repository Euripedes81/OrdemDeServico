using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSolicitante
{
    public partial class FrmSolicitante : Form
    {
        private Solicitante solicitante;
        private List<Solicitante> solicitantes = new List<Solicitante>();
        private Setor setor;
        public FrmSolicitante()
        {
            InitializeComponent();
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddSolicitante frmAddSolicitante = new FrmAddSolicitante();
            frmAddSolicitante.MdiParent = FrmPrincipal.ActiveForm;
            frmAddSolicitante.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, solicitantes, setor);
        }


        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (HandlerDataGridView.ObterLinhaDgv(dgv, solicitante))
            {
                FrmEdtSolicitante frmEdtSolicitante = new FrmEdtSolicitante(solicitante);
                frmEdtSolicitante.MdiParent = FrmPrincipal.ActiveForm;
                frmEdtSolicitante.Show();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if(HandlerDataGridView.ObterLinhaDgv(dgv, solicitante))
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    try
                    {
                        DeleteData.Excluir(solicitante);
                    }
                    catch (Exception)
                    {

                        MensagemEntidades.SolicitanteMsgExcluir();
                    }
                    HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, solicitantes, setor);
                }
            }
        }       
    }
}
