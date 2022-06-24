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
        private readonly TextBox _txtMaquinaPatrimonio;
        private readonly TextBox _txtMaquinaDescricao;
        private readonly Maquina _maquina;       
       
        public FrmMaquinaOs(TextBox txtMaquinaPatrimonio, TextBox txtMaquinaDescricao, Maquina maquina)
        {
            InitializeComponent();
            _txtMaquinaPatrimonio = txtMaquinaPatrimonio;
            _txtMaquinaDescricao = txtMaquinaDescricao;
            _maquina = maquina;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, new List<Maquina>(), new Setor());
            }
            else
            {
                HandlerDataGridView.PesquisaDgvTudoMaquina(dgv, new List<Maquina>(), new Setor());
            }
        }
        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            if (HandlerDataGridView.ObterLinhaDgv(dgv, _maquina))
            {
                _txtMaquinaPatrimonio.Text = Convert.ToString(_maquina.Patrimonio);
                _txtMaquinaDescricao.Text = _maquina.Descricao;
                this.Close(); 
            }
        }    
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (txtPesquisar.Text != "")
            {
                HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, new List<Maquina>(), new Setor());
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
