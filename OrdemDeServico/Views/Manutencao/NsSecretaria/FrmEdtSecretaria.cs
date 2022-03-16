using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmEdtSecretaria : Form
    {
        private Secretaria _secretaria;
        public FrmEdtSecretaria(Secretaria secretaria)
        {
            InitializeComponent();
            _secretaria = secretaria;
        }
        private void FrmEditar_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(_secretaria.Id);
            txtNome.Text = _secretaria.Nome;
            txtDescricao.Text = _secretaria.Descricao;
            mtxtTelefone.Text = _secretaria.Telefone;
        }
        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (ValidadorCampoHelper.CampoBranco(txtNome.Text, txtDescricao.Text, mtxtTelefone.Text))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        _secretaria.Id = Convert.ToInt32(txtId.Text);
                        _secretaria.Nome = txtNome.Text;
                        _secretaria.Descricao = txtDescricao.Text;
                        _secretaria.Telefone = mtxtTelefone.Text;
                        InsertData.Inserir(_secretaria);
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MensagemEntidades.SecretariaMsgAdicionar();
                    }
                    Limpar();
                }
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            mtxtTelefone.Text = "";

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
