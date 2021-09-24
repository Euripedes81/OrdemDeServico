using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmSecretaria : Form
    {
        private Secretaria secretaria = new Secretaria();
        private List<Secretaria> secretarias = new List<Secretaria>();
        public FrmSecretaria()
        {
            InitializeComponent();
        }

        private void tsbAdicionar_Click(object sender, System.EventArgs e)
        {
            FrmAddSecreteria frmAdicionar = new FrmAddSecreteria();
            frmAdicionar.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            PesquisaDgv();
        }

        private void tsbEditar_Click(object sender, System.EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                FrmEdtSecretaria frmEditar = new FrmEdtSecretaria(secretaria);
                frmEditar.ShowDialog();
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
                        CrudHelper.Excluir(secretaria);
                        PesquisaDgv();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void CriarDgv()
        {
            string[] nomeColuna = new string[] { "Id", "Nome", "Descricao", "Telefone" };
            string[] textoColuna = new string[] { "Id", "Nome", "Descrição", "Telefone" };
            int[] tamanho = new[] { 50, 250, 250, 100 };
            Criador.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho);
        }
        private void PesquisaDgv()
        {
            CriarDgv();
            if ((secretarias = PesquisadorHelper.PesquisarSecretaria(txtPesquisar.Text)) != null)
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
                secretaria.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                secretaria.Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                secretaria.Descricao = dgv.CurrentRow.Cells[2].Value.ToString();
                secretaria.Telefone = dgv.CurrentRow.Cells[3].Value.ToString();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
