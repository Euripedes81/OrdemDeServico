using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Windows.Forms;

namespace OrdemDeServico.Views.OS.NsAbrir
{
    public partial class FrmRelatorioOsFechada : Form
    {
        private OrdemServico _ordemServico;
        private readonly FrmFechaOs _frmFechaOs;
        public FrmRelatorioOsFechada(OrdemServico ordemServico, FrmFechaOs frmFechaOs)
        {
            InitializeComponent();
            _ordemServico = ordemServico;
            _frmFechaOs = frmFechaOs;
            frmFechaOs.Close();
        }
        public FrmRelatorioOsFechada(OrdemServico ordemServico)
        {
            InitializeComponent();
            this._ordemServico = ordemServico;            
        }
        private void FrmRelatorioOsFechada_Load(object sender, EventArgs e)
        {            
            this.rptvOsFechada.Clear();
            this.rptvOsFechada.RefreshReport();
            this.rptvOsFechada.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptvOsFechada.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.ordemServicoBindingSource.Clear();
            _ordemServico = SelectData.PesquisarOrdemServicoId(_ordemServico.Id);
            _ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(_ordemServico.SolicitanteOs.Id);
            _ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(_ordemServico.MaquinaOs.Id);
            _ordemServico.SetorOs = SelectData.PesquisarSetorId(_ordemServico.MaquinaOs.SetorMqn.Id);
            _ordemServico.SetorOs.SecretariaStr = SelectData.PesquisarSecretariaId(_ordemServico.SetorOs.SecretariaStr.Id);
            _ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(_ordemServico.AtendenteOs.Id);
            this.rptvOsFechada.RefreshReport();
            this.ordemServicoBindingSource.Add(_ordemServico);
        }
    }
}
