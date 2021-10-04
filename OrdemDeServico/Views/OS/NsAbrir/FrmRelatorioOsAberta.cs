using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmRelatorioOsAberta : Form
    {
        OrdemServico ordemServico;
        public FrmRelatorioOsAberta(OrdemServico ordemServico)
        {
            InitializeComponent();
            this.ordemServico = ordemServico;
        }

        private void FrmRelatorioOsAberta_Load(object sender, EventArgs e)
        {
            this.rprtvOsAberta.Clear();
            this.rprtvOsAberta.RefreshReport();

            this.rprtvOsAberta.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rprtvOsAberta.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.ordemServicoBindingSource.Clear();
            ordemServico = PesquisadorHelper.PesquisarOrdemServicoId(ordemServico.Id);
            ordemServico.SolicitanteOs = PesquisadorHelper.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
            ordemServico.MaquinaOs = PesquisadorHelper.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);            
            this.rprtvOsAberta.RefreshReport();
            this.ordemServicoBindingSource.Add(ordemServico);
                        
        }
    }
}
