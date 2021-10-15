using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmEdtSecretaria : Form
    {
        private Secretaria secretaria = new Secretaria();
        public FrmEdtSecretaria(Secretaria secretaria)
        {
            InitializeComponent();
            this.secretaria = secretaria;
        }
        private void FrmEditar_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(secretaria.Id);
            txtNome.Text = secretaria.Nome;
            txtDescricao.Text = secretaria.Descricao;
            mtxtTelefone.Text = secretaria.Telefone;
        }
        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (Validador.CampoBranco(txtNome.Text, txtDescricao.Text, mtxtTelefone.Text))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    try
                    {
                        secretaria.Id = Convert.ToInt32(txtId.Text);
                        secretaria.Nome = txtNome.Text;
                        secretaria.Descricao = txtDescricao.Text;
                        secretaria.Telefone = mtxtTelefone.Text;
                        CrudHelper.Inserir(secretaria);
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        Mensagem.SecretariaMsgAdicionar();
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
