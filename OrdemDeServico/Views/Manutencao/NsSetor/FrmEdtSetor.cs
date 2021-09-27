using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSetor
{
    public partial class FrmEdtSetor : Form
    {
        private Setor setor = new Setor();
        private List<Secretaria> secretarias;
        public FrmEdtSetor(Setor setor)
        {
            InitializeComponent();
            this.setor = setor;
        }
        private void FrmEdtSetor_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            txtId.Text = Convert.ToString(setor.Id);
            txtNome.Text = setor.Nome;
            txtDescricao.Text = setor.Descricao;
            cbSecretaria.SelectedIndex = cbSecretaria.Items.IndexOf(setor.SecretariaStr.Nome);
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
                        setor.Id = Convert.ToInt32(txtId.Text);
                        setor.Nome = txtNome.Text;
                        setor.Descricao = txtDescricao.Text;
                        setor.SecretariaStr.Id = secretarias[cbSecretaria.SelectedIndex].Id;
                        CrudHelper.Inserir(setor);
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
            cbSecretaria.SelectedIndex = -1;
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
