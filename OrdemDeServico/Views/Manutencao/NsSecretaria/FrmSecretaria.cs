using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmSecretaria : Form
    {
        private Secretaria _secretaria;
        private List<Secretaria> secretarias;
        public FrmSecretaria(Secretaria secretaria)
        {
            InitializeComponent();
            _secretaria = secretaria;
        }

        private void tsbAdicionar_Click(object sender, System.EventArgs e)
        {
            FrmAddSecreteria frmAdicionar = new FrmAddSecreteria();
            frmAdicionar.MdiParent = FrmPrincipal.ActiveForm;
            frmAdicionar.Show();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            PesquisaDgv();
        }

        private void tsbEditar_Click(object sender, System.EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                FrmEdtSecretaria frmEditar = new FrmEdtSecretaria(_secretaria);
                frmEditar.MdiParent = FrmPrincipal.ActiveForm;
                frmEditar.Show();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    try
                    {
                        DeleteData.Excluir(_secretaria);
                        PesquisaDgv();
                    }
                    catch (Exception)
                    {

                        MensagemEntidades.SecretariaMsgExcluir();
                    }
                }
            }
        }
        private void CriarDgv()
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Telefone" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Telefone" };
            int[] tamanho = new[] { 50, 250, 250, 100 };
            CriadorDataCridViewHelper.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho);
        }
        private void PesquisaDgv()
        {
            CriarDgv();
            if ((secretarias = SelectData.PesquisarSecretaria(txtPesquisar.Text)) != null)
            {
                foreach (Secretaria secretaria in secretarias)
                {
                    dgv.Rows.Add(secretaria.Id, secretaria.Nome, secretaria.Descricao, secretaria.Telefone);
                }
            }
        }
        private bool ObterLinhaDgv()
        {

            if (dgv.SelectedRows.Count > 0)
            {
                _secretaria.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                _secretaria.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                _secretaria.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                _secretaria.Telefone = dgv.CurrentRow.Cells[3].Value.ToString();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
