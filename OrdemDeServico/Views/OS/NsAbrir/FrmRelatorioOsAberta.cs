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
            ordemServico = SelectData.PesquisarOrdemServicoId(ordemServico.Id);
            ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);           
            ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
            ordemServico.SetorOs = SelectData.PesquisarSetorId(ordemServico.MaquinaOs.SetorMqn.Id);
            ordemServico.SetorOs.SecretariaStr = SelectData.PesquisarSecretariaId(ordemServico.SetorOs.SecretariaStr.Id);            
            this.rprtvOsAberta.RefreshReport();
            this.ordemServicoBindingSource.Add(ordemServico);
                        
        }
    }
}
