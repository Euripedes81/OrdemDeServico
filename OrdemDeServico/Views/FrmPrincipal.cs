using OrdemDeServico.Model;
using OrdemDeServico.Views.Manutencao.NsMaquina;
using OrdemDeServico.Views.Manutencao.NsSecretaria;
using OrdemDeServico.Views.Manutencao.NsSetor;
using OrdemDeServico.Views.Manutencao.NsSolicitante;
using OrdemDeServico.Views.OS.NsAbrir;
using OrdemDeServico.Views.Relatorios;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views
{
    public partial class FrmPrincipal : Form
    {
        FrmLogin frmLogin = new FrmLogin();
        public static Atendente atendenteLogin { get; set; }
        public FrmPrincipal()
        {            
            InitializeComponent();
            frmLogin.ShowDialog();            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (atendenteLogin == null)
            {
                this.Close();
            }
            else 
            {
                tslUsuario.Text = atendenteLogin.Usuario;
                tslNome.Text = atendenteLogin.Nome;                
            }
        }
        private void SecretariaTsmi_Click(object sender, EventArgs e)
        {
            FrmSecretaria frmSecretaria = new FrmSecretaria(new Secretaria());
            frmSecretaria.MdiParent = this;
            frmSecretaria.Show();

        }

        private void SetorTsmi_Click(object sender, EventArgs e)
        {
            FrmSetor frmSetor = new FrmSetor();
            frmSetor.MdiParent = this;
            frmSetor.Show();
        }

        private void FuncionarioTsmi_Click(object sender, EventArgs e)
        {
            FrmSolicitante frmSolicitante = new FrmSolicitante();
            frmSolicitante.MdiParent = this;
            frmSolicitante.Show();
        }

        private void MaquinaTsmi_Click(object sender, EventArgs e)
        {
            FrmMaquina frmMaquina = new FrmMaquina();
            frmMaquina.MdiParent = this;
            frmMaquina.Show();
        }

        private void GerenciadorOsTsmi_Click(object sender, EventArgs e)
        {
            FrmAbreOs frmAbreOs = new FrmAbreOs(atendenteLogin, new OrdemServico());
            frmAbreOs.MdiParent = this;
            frmAbreOs.Show();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaOs frmConsultaOs = new FrmConsultaOs();
            frmConsultaOs.MdiParent = this;
            frmConsultaOs.Show();
        }
        private void TsbAterarSenha_Click(object sender, EventArgs e)
        {
            FrmSenha frmSenha = new FrmSenha(atendenteLogin);
            frmSenha.MdiParent = this;
            frmSenha.Show();
        }
        private void TsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSetorOsRelatorio frmSetorOsRelatorio = new FrmSetorOsRelatorio();            
            frmSetorOsRelatorio.Show();
        }
    }
}