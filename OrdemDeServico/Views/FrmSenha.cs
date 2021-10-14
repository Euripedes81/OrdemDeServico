using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemDeServico.Views
{
    public partial class FrmSenha : Form
    {
        Atendente atendente;
        public FrmSenha(Atendente atendente)
        {
            InitializeComponent();
            this.atendente = atendente;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(Validador.CampoBranco(atendente.Nome, txtSenhaAtual.Text))
            {
                if(Validador.ValidaSenha( txtNovaSenha.Text, txtConfirSenha.Text))
                {
                    atendente.Senha = txtConfirSenha.Text;
                    CrudHelper.Inserir(atendente);
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
