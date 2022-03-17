using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmSecretaria : Form
    {
        private readonly Secretaria _secretaria;        
        public FrmSecretaria(Secretaria secretaria)
        {
            InitializeComponent();
            _secretaria = secretaria;
        }

        private void tsbAdicionar_Click(object sender, System.EventArgs e)
        {
            FrmAddSecreteria frmAdicionar = new FrmAddSecreteria();
            frmAdicionar.MdiParent = FrmPrincipal.ActiveForm;
            frmAdicionar.Show();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, new List<Secretaria>());
        }

        private void tsbEditar_Click(object sender, System.EventArgs e)
        {
            if (HandlerDataGridView.ObterLinhaDgv(dgv, _secretaria))
            {
                FrmEdtSecretaria frmEditar = new FrmEdtSecretaria(_secretaria);
                frmEditar.MdiParent = FrmPrincipal.ActiveForm;
                frmEditar.Show();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (HandlerDataGridView.ObterLinhaDgv(dgv, _secretaria))
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    try
                    {
                        DeleteData.Excluir(_secretaria);
                        HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, new List<Secretaria>());
                    }
                    catch (Exception)
                    {
                        MensagemEntidades.SecretariaMsgExcluir();
                    }
                }
            }
        }       
       
       
    }    
}
