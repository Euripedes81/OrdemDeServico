using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmAddOs : Form
    {
        private Solicitante solicitante = new Solicitante();
        private Maquina maquina = new Maquina();
        private readonly Atendente _atendente;
        public FrmAddOs(Atendente atendente)
        {
            InitializeComponent();
            _atendente = atendente;
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
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.SolicitanteOs = solicitante;
            ordemServico.MaquinaOs = maquina;
            ordemServico.SetorOs = maquina.SetorMqn;
            ordemServico.Diagnostico = txtDiagnostico.Text;
            ordemServico.DataAbertura = DateTime.Now;
            ordemServico.AtendenteOs = _atendente;
            if (ValidadorCampoHelper.CampoBranco(txtSolicitante.Text, txtPatrimonio.Text, txtDiagnostico.Text ) && 
                (MessageBox.Show("Deseja salvar essa O.S?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if(solicitante.SetorSolicitante.Id == maquina.SetorMqn.Id)
                {
                    InsertData.Inserir(ordemServico);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Solicitante e Máquina não pertencem ao mesmo setor!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            txtDiagnostico.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
