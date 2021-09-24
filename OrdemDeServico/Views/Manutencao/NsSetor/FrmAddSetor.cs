using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSetor
{
    public partial class FrmAddSetor : Form
    {
        private List<Secretaria> secretarias;
        public FrmAddSetor()
        {
            InitializeComponent();
        }
        private void FrmAddSetor_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(txtNome.Text, txtDescricao.Text, cbSecretaria))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        Setor setor = new Setor();
                        setor.Nome = txtNome.Text;
                        setor.Descricao = txtDescricao.Text;
                        setor.secretaria.Id = secretarias[cbSecretaria.SelectedIndex].Id;
                        CrudHelper.Inserir(setor);
                        Limpar();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void CarregarComboBox()
        {
            if ((secretarias = PesquisadorHelper.PesquisarSecretaria("")) != null)
            {
                foreach (Secretaria secretaria in secretarias)
                {
                    cbSecretaria.Items.Add(secretaria.ToString());
                }
            }

        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            cbSecretaria.SelectedIndex = -1;
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
