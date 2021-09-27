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

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmAddOs : Form
    {
        private Solicitante solicitante = new Solicitante();
        private Maquina maquina = new Maquina();
        public FrmAddOs()
        {
            InitializeComponent();
        }

        private void tsbPesquisarSolicitante_Click(object sender, EventArgs e)
        {
            FrmSolicitanteOs frmSolicitanteOs = new FrmSolicitanteOs(txtSolicitante, txtDescricaoSolicitante, solicitante);
            frmSolicitanteOs.MdiParent = FrmPrincipal.ActiveForm;
            frmSolicitanteOs.Show();
        }
        private void tsbPesquisarMaquina_Click(object sender, EventArgs e)
        {
            FrmMaquinaOs frmMaquinaOs = new FrmMaquinaOs(txtPatrimonio, txtDescricaoMaquina, maquina);
            frmMaquinaOs.MdiParent = FrmPrincipal.ActiveForm;
            frmMaquinaOs.Show();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validador.CampoBranco(txtSolicitante.Text, txtPatrimonio.Text, txtDiagnostico.Text ) && 
                (MessageBox.Show("Deseja salvar essa O.S?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if(solicitante.SetorSlc.Id == maquina.SetorMqn.Id)
                {
                    Limpar();
                }
                else if(MessageBox.Show("Solicitante e Máquina não pertencem ao mesmo setor!\nDeseja continuar?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpar();
                }
                
            }
            
        }
        private void Limpar()
        {
            txtSolicitante.Text = "";
            txtDescricaoSolicitante.Text = "";
            txtPatrimonio.Text = "";
            txtDescricaoMaquina.Text = "";
            txtDiagnostico.Text = "";
        }

        private void txtDiagnostico_KeyPress(object sender, KeyPressEventArgs e)
        {
           txtDiagnostico.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
