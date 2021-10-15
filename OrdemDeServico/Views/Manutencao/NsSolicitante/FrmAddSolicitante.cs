using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSolicitante
{
    public partial class FrmAddSolicitante : Form
    {
        private List<Setor> setores;
        public FrmAddSolicitante()
        {
            InitializeComponent();
        }
        private void FrmAddSolicitante_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
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
                        Solicitante solicitante = new Solicitante();
                        solicitante.Nome = txtNome.Text;
                        solicitante.Descricao = txtDescricao.Text;
                        solicitante.SetorSlc.Id = setores[cbSetor.SelectedIndex].Id;
                        CrudHelper.Inserir(solicitante);
                        Limpar();
                    }
                    catch (Exception ex)
                    {

                        Mensagem.SolicitanteMsgAdicionar();
                    }
                }
            }
        }
        private void CarregarComboBox()
        {
            if ((setores = PesquisadorHelper.PesquisarSetor("")) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }
            }

        }
        private void Limpar()
        {
            
            txtNome.Text = "";
            txtDescricao.Text = "";
            cbSetor.SelectedIndex = -1;
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
