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
        Solicitante solicitante = new Solicitante();
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
    }
}
