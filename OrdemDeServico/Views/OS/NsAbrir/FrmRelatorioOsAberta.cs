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

            
            this.rprtvOsAberta.RefreshReport();
            this.ordemServicoBindingSource.Add(ordemServico);
                        
        }
    }
}
