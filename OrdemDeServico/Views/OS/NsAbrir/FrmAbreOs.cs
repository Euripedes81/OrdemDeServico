using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{


    public partial class FrmAbreOs : Form
    {
        private Atendente atendente = new Atendente();
        private int numeroOs;
        private OrdemServico ordemServico;
        public FrmAbreOs()
        {
            InitializeComponent();
        }

        private void txtPesquisarNome_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisarOs.ReadOnly = true;
            txtPesquisarNome.ReadOnly = false ;
        }      
                
        private void txtPesquisarOs_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisarNome.ReadOnly = true;
            txtPesquisarOs.ReadOnly = false;
        }
        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddOs frmAddOs = new FrmAddOs();
            frmAddOs.MdiParent = FrmPrincipal.ActiveForm;
            frmAddOs.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {            
            if (txtPesquisarNome.ReadOnly == false)
            {
                AdicionaDgvHelper.PesquisaDgv(dgv, txtPesquisarNome.Text);
            }            
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            atendente.Id = 1;
            atendente.Usuario = "euripedes";
            if (!string.IsNullOrWhiteSpace(txtPesquisarOs.Text))
            {
                numeroOs = (int)Convert.ToInt64(txtPesquisarOs.Text);
                AdicionaDgvHelper.PesquisaDgv(dgv, numeroOs); 
            }
        }

        private void txtPesquisaOs_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void txtPesquisaOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            ordemServico = new OrdemServico();
            atendente.Id = 2;
            atendente.Usuario = "euripedes";
            if (AdicionaDgvHelper.ObterLinhaDgvOs(dgv, ordemServico))
            {
                if(ordemServico.AtendenteOs.Id == atendente.Id)
                {
                    if (MessageBox.Show("Deseja excluir esta O.S?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CrudHelper.Excluir(ordemServico); 
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para excluir este registro!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tsbVisualizar_Click(object sender, EventArgs e)
        {
            ordemServico = new OrdemServico();
            if (AdicionaDgvHelper.ObterLinhaDgvOs(dgv, ordemServico))
            {
                FrmRelatorioOsAberta frmRelatorioOsAberta = new FrmRelatorioOsAberta(ordemServico);
                //frmRelatorioOsAberta.MdiParent = FrmPrincipal.ActiveForm;
                frmRelatorioOsAberta.Show(); 
            }
        }
    }
}
