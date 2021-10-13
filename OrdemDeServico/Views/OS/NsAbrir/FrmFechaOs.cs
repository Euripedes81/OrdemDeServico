using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmFechaOs : Form
    {
        private OrdemServico ordemServico;
        public FrmFechaOs(OrdemServico ordemServico)
        {
            InitializeComponent();
            this.ordemServico = ordemServico;
        }

        private void FrmFechaOs_Load(object sender, System.EventArgs e)
        {
            txtNumeroOs.Text = Convert.ToString(ordemServico.Id);
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(txtSolucao.Text))
            {
                ordemServico.Solucao = txtSolucao.Text;
                ordemServico.Observacao = txtSolucao.Text;
                ordemServico.DataFechamento = DateTime.Now;
                CrudHelper.Inserir(ordemServico);
                FrmRelatorioOsFechada frmRelatorioOsFechada = new FrmRelatorioOsFechada(ordemServico, this);
                frmRelatorioOsFechada.Show();
            }
        }

        private void txtSolucao_TextChanged(object sender, EventArgs e)
        {
            txtSolucao.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
