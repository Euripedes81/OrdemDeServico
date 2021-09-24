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
            ;
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            ObterLinhaDgv();
            txtSolicitante.Text = solicitante.Nome;
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaDgv();
        }
        private void CriarDgv()
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Setor", "IdSetor", "Secretaria" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Setor", "IdSetor", "Secretaria" };
            int[] tamanho = new[] { 50, 250, 250, 250, 50, 250 };
            bool[] visibilidade = new[] { true, true, true, true, false, true };
            Criador.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
        }
        private void PesquisaDgv()
        {
            CriarDgv();
            if ((solicitantes = PesquisadorHelper.PesquisarSolicitante(txtPesquisar.Text)) != null)
            {
                foreach (Solicitante solicitante in solicitantes)
                {
                    if ((this.setor = PesquisadorHelper.PesquisarSetor(solicitante.setor.Id)) != null)
                    {
                        solicitante.setor = this.setor;
                        if ((solicitante.setor.secretaria = PesquisadorHelper.PesquisarSecretaria(solicitante.setor.secretaria.Id)) != null)
                        {
                            dgv.Rows.Add(solicitante.Id, solicitante.Nome, solicitante.Descricao, solicitante.setor.Nome,
                                solicitante.setor.Id, solicitante.setor.secretaria.Nome);
                        }

                    }
                }
            }
        }
        private bool ObterLinhaDgv()
        {

            if (dgv.SelectedRows.Count > 0)
            {
                solicitante.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                solicitante.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                solicitante.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                solicitante.setor.Nome = dgv.CurrentRow.Cells[3].Value.ToString();
                solicitante.setor.Id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
