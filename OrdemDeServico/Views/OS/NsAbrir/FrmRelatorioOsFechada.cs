using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmRelatorioOsFechada : Form
    {
        private OrdemServico ordemServico;
        private FrmFechaOs frmFechaOs;
        public FrmRelatorioOsFechada(OrdemServico ordemServico, FrmFechaOs frmFechaOs)
        {
            InitializeComponent();
            this.ordemServico = ordemServico;
            this.frmFechaOs = frmFechaOs;
            frmFechaOs.Close();
        }
        public FrmRelatorioOsFechada(OrdemServico ordemServico)
        {
            InitializeComponent();
            this.ordemServico = ordemServico;            
        }
        private void FrmRelatorioOsFechada_Load(object sender, EventArgs e)
        {            
            this.rptvOsFechada.Clear();
            this.rptvOsFechada.RefreshReport();
            this.rptvOsFechada.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptvOsFechada.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.ordemServicoBindingSource.Clear();
            ordemServico = SelectData.PesquisarOrdemServicoId(ordemServico.Id);
            ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
            ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
            ordemServico.SetorOs = SelectData.PesquisarSetorId(ordemServico.MaquinaOs.SetorMqn.Id);
            ordemServico.SetorOs.SecretariaStr = SelectData.PesquisarSecretariaId(ordemServico.SetorOs.SecretariaStr.Id);
            ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
            this.rptvOsFechada.RefreshReport();
            this.ordemServicoBindingSource.Add(ordemServico);
        }
    }
}
