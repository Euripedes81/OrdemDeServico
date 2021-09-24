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
            FrmSolicitanteOs frmSolicitanteOs = new FrmSolicitanteOs(txtSolicitante, solicitante);
            frmSolicitanteOs.MdiParent = FrmPrincipal.ActiveForm;
            frmSolicitanteOs.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMaquinaOs frmMaquinaOs = new FrmMaquinaOs(txtPatrimonio, txtDescricaoMaquina, maquina);
            frmMaquinaOs.MdiParent = FrmPrincipal.ActiveForm;
            frmMaquinaOs.Show();
        }
    }
}
