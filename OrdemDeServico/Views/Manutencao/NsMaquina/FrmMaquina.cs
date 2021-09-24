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

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmMaquina : Form
    {
        private Maquina maquina = new Maquina();
        private List<Maquina> maquinas = new List<Maquina>();
        private Setor setor;
        public FrmMaquina()
        {
            InitializeComponent();
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddMaquina frmAddMaquina = new FrmAddMaquina();
            frmAddMaquina.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                PesquisaDgv();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (ObterLinhaDgv())
            {
                FrmEdtMaquina frmEdtMaquina = new FrmEdtMaquina(maquina);
                frmEdtMaquina.ShowDialog();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if(ObterLinhaDgv())
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                {
                    CrudHelper.Excluir(maquina);
                    PesquisaDgv();
                }
            }
        }
        private void CriarDgv()
        {
            string[] nomeColuna = new string[] { "Id", "Patrimonio","Tipo", "Descricao", "Setor", "IdSetor", "Secretaria" };
            string[] textoColuna = new string[] { "Id", "Patrimônio", "Tipo", "Descrição", "Setor", "IdSetor", "Secretaria" };
            int[] tamanho = new[] { 50,100, 250, 250, 250, 50, 250 };
            bool[] visibilidade = new[] { true, true, true, true, true, false, true };
            Criador.CriaDataGridView(dgv, nomeColuna, textoColuna, tamanho, visibilidade);
        }
        private void PesquisaDgv()
        {
            CriarDgv();
            
            int patrimonio = Convert.ToInt32(txtPesquisar.Text);
            if ((maquinas = PesquisadorHelper.PesquisarMaquina(patrimonio)) != null)
            {
                foreach (Maquina maquina in maquinas)
                {
                    if ((this.setor = PesquisadorHelper.PesquisarSetor(maquina.setor.Id)) != null)
                    {
                        maquina.setor = this.setor;
                        if ((maquina.setor.secretaria = PesquisadorHelper.PesquisarSecretaria(maquina.setor.secretaria.Id)) != null)
                        {
                            dgv.Rows.Add(maquina.Id, maquina.Patrimonio, maquina.Tipo, maquina.Descricao, maquina.setor.Nome,
                                maquina.setor.Id, maquina.setor.secretaria.Nome);
                        }

                    }
                }
            }
        }
        private bool ObterLinhaDgv()
        {

            if (dgv.SelectedRows.Count > 0)
            {
                maquina.Id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                maquina.Patrimonio = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value.ToString());
                maquina.Tipo = dgv.CurrentRow.Cells[2].Value.ToString();
                maquina.Descricao = dgv.CurrentRow.Cells[3].Value.ToString();
                maquina.setor.Nome = dgv.CurrentRow.Cells[4].Value.ToString();
                maquina.setor.Id = Convert.ToInt32(dgv.CurrentRow.Cells[5].Value);
                return true;
            }
            else
            {
                return false;
            }

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(txtPesquisar.Text != "")
            {
                PesquisaDgv();
            }           
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;            
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ObterLinhaDgv())
            {
                FrmRelatorioMaquina relatorioMaquina = new FrmRelatorioMaquina(maquina);
                relatorioMaquina.ShowDialog();
                
            }
        }
    }
}
