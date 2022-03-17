using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{


    public partial class FrmAbreOs : Form
    {
        private Atendente _atendente;
        private int numeroOs;
        private OrdemServico _ordemServico;
        public FrmAbreOs(Atendente atendente, OrdemServico ordemDeServico)
        {
            InitializeComponent();
            _atendente = atendente;
            _ordemServico = ordemDeServico;
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
            FrmAddOs frmAddOs = new FrmAddOs(_atendente);
            frmAddOs.MdiParent = FrmPrincipal.ActiveForm;
            frmAddOs.Show();
        }
        private void tsbFecharOs_Click(object sender, EventArgs e)
        {            
            
            if (HandlerDataGridView.ObterLinhaDgvOsAberta(dgv, _ordemServico))
            {
                if (_atendente.Id == _ordemServico.AtendenteOs.Id)
                {
                    _ordemServico.AtendenteOs = _atendente;
                    FrmFechaOs frmFechaOs = new FrmFechaOs(_ordemServico);
                    frmFechaOs.MdiParent = FrmPrincipal.ActiveForm;
                    frmFechaOs.Show(); 
                }else if(MessageBox.Show("Esta O.S foi aberta por outro usuário do sistema.\nDeseja continuar?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ordemServico.AtendenteOs = _atendente;
                    FrmFechaOs frmFechaOs = new FrmFechaOs(_ordemServico);
                    frmFechaOs.MdiParent = FrmPrincipal.ActiveForm;
                    frmFechaOs.Show();
                }
            }
        }
        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            _ordemServico = new OrdemServico();
            
            if (HandlerDataGridView.ObterLinhaDgvOsAberta(dgv, _ordemServico))
            {
                if (_ordemServico.AtendenteOs.Id == _atendente.Id)
                {
                    if (MessageBox.Show("Deseja excluir esta O.S?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteData.Excluir(_ordemServico);
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
            Visualizar();
        }
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visualizar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {            
            if (txtPesquisarNome.ReadOnly == false)
            {
                HandlerDataGridView.PesquisaDgvOsAberta(dgv, txtPesquisarNome.Text);
            }            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            if (!string.IsNullOrWhiteSpace(txtPesquisarOs.Text))
            {
                numeroOs = (int)Convert.ToInt64(txtPesquisarOs.Text);
                HandlerDataGridView.PesquisaDgvOsAberta(dgv, numeroOs); 
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

        private void Visualizar()
        {
            _ordemServico = new OrdemServico();
            if (HandlerDataGridView.ObterLinhaDgvOsAberta(dgv, _ordemServico))
            {
                FrmRelatorioOsAberta frmRelatorioOsAberta = new FrmRelatorioOsAberta(_ordemServico);                
                frmRelatorioOsAberta.Show();
            }
        }
    }
}
