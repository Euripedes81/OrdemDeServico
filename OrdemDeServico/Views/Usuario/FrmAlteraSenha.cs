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

namespace OrdemDeServico.Views.Usuario
{
    public partial class FrmAlteraSenha : Form
    {
        private Atendente atendente;
        public FrmAlteraSenha(Atendente atendente)
        {
            InitializeComponent();
            this.atendente = atendente;
        }
        private void FrmAlteraSenha_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = atendente.Usuario;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            atendente.Senha = txtSenha.Text;
            InsertData.Inserir(atendente);
            this.Close();
        }
               
    }
}
