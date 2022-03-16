using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Usuario
{
    public partial class FrmAddUsuario : Form
    {
        public FrmAddUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidadorCampoHelper.CampoBranco(txtNome.Text, txtUsuario.Text, txtSenha.Text))
            {
                Atendente atendente = new Atendente();
                atendente.Usuario = txtUsuario.Text;
                atendente.Nome = txtNome.Text;
                atendente.Senha = txtSenha.Text;
                try
                {
                    InsertData.Inserir(atendente);
                    Limpar();
                }
                catch (Exception)
                {
                    MensagemEntidades.AtendenteMsgAdicionar();                   
                }
                
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
