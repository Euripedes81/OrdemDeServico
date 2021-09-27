using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmMaquinaOs : Form
    {
        private TextBox txtMaquinaPatrimonio;
        private TextBox txtMaquinaDescricao;
        private Maquina maquina = new Maquina();
        private List<Maquina> maquinas = new List<Maquina>();
        private Setor setor;
        public FrmMaquinaOs(TextBox txtMaquinaPatrimonio, TextBox txtMaquinaDescricao, Maquina maquina)
        {
            InitializeComponent();
            this.txtMaquinaPatrimonio = txtMaquinaPatrimonio;
            this.txtMaquinaDescricao = txtMaquinaDescricao;
            this.maquina = maquina;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                AdicionaDgvHelper.PesquisaDgv(dgv, txtPesquisar, maquinas, setor);
            }
        }
        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            if (AdicionaDgvHelper.ObterLinhaDgv(dgv, maquina))
            {
                txtMaquinaPatrimonio.Text = Convert.ToString(maquina.Patrimonio);
                txtMaquinaDescricao.Text = maquina.Descricao;
                this.Close(); 
            }
        }    
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (txtPesquisar.Text != "")
            {
                AdicionaDgvHelper.PesquisaDgv(dgv, txtPesquisar, maquinas, setor);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
       
    }
}
