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
        TextBox txtDescricaoSolicitante;
        public FrmSolicitanteOs(TextBox txtSolicitante, TextBox txtDescricaoSolicitante, Solicitante solicitante)
        {
            InitializeComponent();
            this.txtSolicitante = txtSolicitante;
            this.txtDescricaoSolicitante = txtDescricaoSolicitante;
            this.solicitante = solicitante;
        }
        public FrmSolicitanteOs()
        {
            InitializeComponent();            
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.ObterLinhaDgv(dgv, solicitante);
            txtSolicitante.Text = solicitante.Nome;
            txtDescricaoSolicitante.Text = solicitante.Descricao;
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, solicitantes, setor);
        }
       
    }
}
