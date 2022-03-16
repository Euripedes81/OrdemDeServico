using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmSolicitanteOs : Form
    {
        private readonly Solicitante _solicitante;            
        private readonly TextBox _txtSolicitante;
        private readonly TextBox _txtDescricaoSolicitante;
        public FrmSolicitanteOs(TextBox txtSolicitante, TextBox txtDescricaoSolicitante, Solicitante solicitante)
        {
            InitializeComponent();
            _txtSolicitante = txtSolicitante;
            _txtDescricaoSolicitante = txtDescricaoSolicitante;
            _solicitante = solicitante;
        }
        public FrmSolicitanteOs()
        {
            InitializeComponent();            
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.ObterLinhaDgv(dgv, _solicitante);
            _txtSolicitante.Text = _solicitante.Nome;
            _txtDescricaoSolicitante.Text = _solicitante.Descricao;
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HandlerDataGridView.PesquisaDgv(dgv, txtPesquisar.Text, new List<Solicitante>(), new Setor());
        }
       
    }
}
