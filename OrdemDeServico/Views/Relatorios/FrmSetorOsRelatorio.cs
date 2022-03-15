using OrdemDeServico.Helpers;
using OrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdemDeServico.Views.Relatorios
{
    public partial class FrmSetorOsRelatorio : Form
    {
        private List<Secretaria> secretarias;
        private List<Setor> setores;
        private List<OrdemServico> ordemServicos;
        public FrmSetorOsRelatorio()
        {
            InitializeComponent();
        }
        private void FrmSetorOsRelatorio_Load(object sender, EventArgs e)
        {
            Criador.FormataDateTimePicker(dtpInicio, dtpFim);            
            CarregarComboBox();
        }    
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.rprtvSetor.Clear();
            this.rprtvSetor.RefreshReport();
            this.rprtvSetor.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rprtvSetor.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.ordemServicoBindingSource.Clear();
            foreach (var setor in setores)
            {
                if ((ordemServicos = PesquisadorHelper.PesquisarOrdemServicos(setor.Id, dtpInicio.Value, dtpFim.Value)) != null)
                {                    
                    foreach(var ordemServico in ordemServicos)
                    {                       
                        ordemServico.SolicitanteOs = PesquisadorHelper.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                        ordemServico.MaquinaOs = PesquisadorHelper.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                        ordemServico.SetorOs = PesquisadorHelper.PesquisarSetorId(ordemServico.MaquinaOs.SetorMqn.Id);
                        ordemServico.SetorOs.SecretariaStr = PesquisadorHelper.PesquisarSecretariaId(ordemServico.SetorOs.SecretariaStr.Id);
                        ordemServico.AtendenteOs = PesquisadorHelper.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                        this.ordemServicoBindingSource.Add(ordemServico);
                        this.rprtvSetor.RefreshReport();
                    }
                } 
            }
        }
        private void CarregarComboBox()
        {
            if ((secretarias = PesquisadorHelper.PesquisarSecretaria("")) != null)
            {
                foreach (Secretaria secretaria in secretarias)
                {
                    cbSecretaria.Items.Add(secretaria.ToString());
                }
            }

        }

        private void cbSecretaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSetor.Items.Clear();
            cbSetor.Text = "";

            if ((setores = PesquisadorHelper.PesquisarSetoresId(secretarias[cbSecretaria.SelectedIndex].Id)) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            Criador.SelecionaDateTimePicker(dtpInicio);
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            Criador.SelecionaDateTimePicker(dtpFim);
        }
    }
}
