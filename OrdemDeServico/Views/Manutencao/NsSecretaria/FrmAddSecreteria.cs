using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Manutencao.NsSecretaria
{
    public partial class FrmAddSecreteria : Form
    {
        public FrmAddSecreteria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(txtNome.Text, txtDescricao.Text, mtxtTelefone.Text))
            {
                if (MessageBox.Show("Deseja salvar os dados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    Secretaria secretaria = new Secretaria();
                    secretaria.Nome = txtNome.Text;
                    secretaria.Descricao = txtDescricao.Text;
                    secretaria.Telefone = mtxtTelefone.Text;
                    try
                    {
                        CrudHelper.Inserir(secretaria);
                    }
                    catch (Exception)
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
