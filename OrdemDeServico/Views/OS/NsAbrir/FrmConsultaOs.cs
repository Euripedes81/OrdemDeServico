using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmConsultaOs : Form
    {
        //private Atendente atendente = new Atendente(2, "rock", "Rock Junior");
        private int numeroOs;
        private OrdemServico ordemServico;
        public FrmConsultaOs()
        {
            InitializeComponent();
        }       
       
        private void txtPesquisarOs_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisarNome.ReadOnly == false)
            {
                AdicionaDgvHelper.PesquisaDgvOsFechada(dgv, txtPesquisarNome.Text);
            }
        }

        private void tsbVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (!string.IsNullOrWhiteSpace(txtPesquisarOs.Text))
            {
                numeroOs = (int)Convert.ToInt64(txtPesquisarOs.Text);
                AdicionaDgvHelper.PesquisaDgvOsFechada(dgv, numeroOs);
            }
        }
        private void txtPesquisaOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPesquisarOs_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtPesquisarNome.ReadOnly = true;
            txtPesquisarOs.ReadOnly = false;
        }

        private void txtPesquisarNome_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtPesquisarOs.ReadOnly = true;
            txtPesquisarNome.ReadOnly = false;
        }
        private void Visualizar()
        {
            ordemServico = new OrdemServico();
            if (AdicionaDgvHelper.ObterLinhaDgvOsFechada(dgv, ordemServico))
            {
                FrmRelatorioOsFechada frmRelatorioOsFechada = new FrmRelatorioOsFechada(ordemServico);
                frmRelatorioOsFechada.Show();
            }
        }
        
    }
}
