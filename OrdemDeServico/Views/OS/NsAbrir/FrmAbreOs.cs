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

namespace OrdemDeServico.Views.OS.NsAbrir{
    
    
    public partial class FrmAbreOs : Form
    {
        private Atendente atendente = new Atendente();
        private int numeroOs;
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
            atendente.Id = 1;
            atendente.Usuario = "euripedes";
            
            if (txtPesquisarNome.ReadOnly == false)
            {
                AdicionaDgvHelper.PesquisaDgv(dgv, txtPesquisarNome.Text, atendente);
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
                AdicionaDgvHelper.PesquisaDgv(dgv, numeroOs, atendente); 
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
       
    }
}
