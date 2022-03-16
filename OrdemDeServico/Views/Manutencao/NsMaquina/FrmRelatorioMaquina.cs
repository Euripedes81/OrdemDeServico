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

namespace OrdemDeServico.Views.Manutencao.NsMaquina
{
    public partial class FrmRelatorioMaquina : Form
    {
        private readonly Maquina _maquina;
        public FrmRelatorioMaquina(Maquina maquina )
        {
            InitializeComponent();
            _maquina = maquina;
        }

        private void FrmRelatorioMaquina_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Clear();
            this.reportViewer1.RefreshReport();       
            
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;            
            this.maquinaBindingSource.Clear();
            _maquina.SetorMqn = SelectData.PesquisarSetorId(_maquina.SetorMqn.Id);
            _maquina.SetorMqn.SecretariaStr = SelectData.PesquisarSecretariaId(_maquina.SetorMqn.SecretariaStr.Id);           
            this.maquinaBindingSource.Add(_maquina);
           
        }
    }
}
