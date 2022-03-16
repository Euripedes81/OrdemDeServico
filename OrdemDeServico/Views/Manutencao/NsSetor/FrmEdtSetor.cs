using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSetor
{
    public partial class FrmEdtSetor : Form
    {
        private readonly Setor _setor;
        private List<Secretaria> secretarias;
        public FrmEdtSetor(Setor setor)
        {
            InitializeComponent();
            _setor = setor;
        }
        private void FrmEdtSetor_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            txtId.Text = Convert.ToString(_setor.Id);
            txtNome.Text = _setor.Nome;
            txtDescricao.Text = _setor.Descricao;
            cbSecretaria.SelectedIndex = cbSecretaria.Items.IndexOf(_setor.SecretariaStr.Nome);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidadorCampoHelper.CampoBranco(txtNome.Text, txtDescricao.Text, cbSecretaria))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        _setor.Id = Convert.ToInt32(txtId.Text);
                        _setor.Nome = txtNome.Text;
                        _setor.Descricao = txtDescricao.Text;
                        _setor.SecretariaStr.Id = secretarias[cbSecretaria.SelectedIndex].Id;
                        InsertData.Inserir(_setor);
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MensagemEntidades.SetorMsgAdicionar();
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
            if ((secretarias = SelectData.PesquisarSecretaria("")) != null)
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
