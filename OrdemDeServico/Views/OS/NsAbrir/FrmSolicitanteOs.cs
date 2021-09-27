using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmSolicitanteOs : Form
    {
        private Solicitante solicitante = new Solicitante();
        private List<Solicitante> solicitantes = new List<Solicitante>();
        private Setor setor;
        TextBox txtSolicitante;
        public FrmSolicitanteOs(TextBox txtSolicitante, Solicitante solicitante)
        {
            InitializeComponent();
            this.txtSolicitante = txtSolicitante;
            this.solicitante = solicitante;
        }
        public FrmSolicitanteOs()
        {
            InitializeComponent();            
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            AdicionaDgvHelper.ObterLinhaDgv(dgv, solicitante);
            txtSolicitante.Text = solicitante.Nome;
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AdicionaDgvHelper.PesquisaDgv(dgv, txtSolicitante, solicitantes, setor);
        }
       
    }
}
