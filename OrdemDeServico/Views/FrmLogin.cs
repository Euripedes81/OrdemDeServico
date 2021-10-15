using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views
{
    public partial class FrmLogin : Form
    {
        private Atendente atendente; 
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((atendente = PesquisadorHelper.PesquisarAtendenteNome(txtUsuario.Text)) != null)
            {
                if (PesquisadorHelper.PesquisarAtendenteSenha(atendente.Id, txtSenha.Text))
                {
                    if (atendente.Id != 1)
                    {
                        FrmPrincipal.atendenteLogin = atendente;
                        this.Close();
                    }
                    else
                    {
                        FrmAdmin frmAdmin = new FrmAdmin();
                        frmAdmin.ShowDialog();
                    }
                }
                else 
                { 
                    MessageBox.Show("As senhas digitadas não conferem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Este usuário não existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
