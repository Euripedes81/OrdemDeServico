using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSolicitante
{
    public partial class FrmEdtSolicitante : Form
    {
        private Solicitante solicitante = new Solicitante();
        private List<Setor> setores;
        public FrmEdtSolicitante(Solicitante solicitante)
        {
            InitializeComponent();
            this.solicitante = solicitante;
        }

        private void FrmEdtSolicitante_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            txtId.Text = Convert.ToString(solicitante.Id);
            txtNome.Text = solicitante.Nome;
            txtDescricao.Text = solicitante.Descricao;
            cbSetor.SelectedIndex = cbSetor.Items.IndexOf(solicitante.setor.Nome);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(txtNome.Text, txtDescricao.Text, cbSetor))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        solicitante.Id = Convert.ToInt32(txtId.Text);
                        solicitante.Nome = txtNome.Text;
                        solicitante.Descricao = txtDescricao.Text;
                        solicitante.setor.Id = setores[cbSetor.SelectedIndex].Id;
                        CrudHelper.Inserir(solicitante);
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    Limpar();
                }
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            cbSetor.SelectedIndex = -1;
        }
        private void CarregarComboBox()
        {
            if ((setores = PesquisadorHelper.PesquisarSetor("")) != null)
            {
                foreach (Setor  setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
