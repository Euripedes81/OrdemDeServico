using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views
{
    public partial class FrmSenha : Form
    {
        private readonly Atendente _atendente;
        public FrmSenha(Atendente atendente)
        {
            InitializeComponent();
            _atendente = atendente;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(ValidadorCampoHelper.CampoBranco(_atendente.Nome, txtSenhaAtual.Text))
            {
                if(ValidadorCampoHelper.ValidaSenha( txtNovaSenha.Text, txtConfirSenha.Text))
                {
                    _atendente.Senha = txtConfirSenha.Text;
                    InsertData.Inserir(_atendente);
                    this.Close();
                }
                else
                {
                    Limpar();
                   
                }
            }
            else
            {
                Limpar();
                MessageBox.Show("Senha incorreta!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Limpar()
        {
            txtSenhaAtual.Text = "";
            txtNovaSenha.Text = "";
            txtConfirSenha.Text = "";
        }
    }
}
