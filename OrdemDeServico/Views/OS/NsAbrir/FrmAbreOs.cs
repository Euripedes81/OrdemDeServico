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
        private List<OrdemServico> ordemServicos;
        private Atendente atendente = new Atendente();       
        public FrmAbreOs()
        {
            InitializeComponent();
        }

        private void txtPesquisarNome_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtPesquisarOs.ReadOnly = true;
            txtPesquisarNome.ReadOnly = false ;
        }
        

        private void mtxtPesquisarOs_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisarNome.ReadOnly = true;
            mtxtPesquisarOs.ReadOnly = false;
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
            if(txtPesquisarNome.Enabled == true)
            {
                AdicionaDgvHelper.PesquisaDgv(dgv, txtPesquisarNome.Text, atendente);
            }
        }
    }
}
