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
            CriadorDateTimePickerHelper.FormataDateTimePicker(dtpInicio, dtpFim);            
            CarregarComboBox();
        }    
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.rprtvSetor.Clear();
            this.rprtvSetor.RefreshReport();
            this.rprtvSetor.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rprtvSetor.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.ordemServicoBindingSource.Clear();

            if (cbSecretaria.SelectedIndex >= 0)
            {
                if (cbSetor.SelectedIndex >= 0)
                {
                    if ((ordemServicos = SelectData.PesquisarOrdemServicoIdSetor(setores[cbSetor.SelectedIndex].Id, dtpInicio.Value, dtpFim.Value)) != null)
                    {
                        GerarRelatorio(ordemServicos);
                    }
                }
                else
                {
                    foreach (var setor in setores)
                    {
                        if ((ordemServicos = SelectData.PesquisarOrdemServicoIdSetor(setor.Id, dtpInicio.Value, dtpFim.Value)) != null)
                        {
                            GerarRelatorio(ordemServicos);
                        }
                    }
                } 
            }
        }
        private void CarregarComboBox()
        {
            if ((secretarias = SelectData.PesquisarSecretaria("")) != null)
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

            if ((setores = SelectData.PesquisarSetoresId(secretarias[cbSecretaria.SelectedIndex].Id)) != null)
            {
                foreach (Setor setor in setores)
                {
                    cbSetor.Items.Add(setor.ToString());
                }
            }
        }

        private void GerarRelatorio(List<OrdemServico> ordemServicos)
        {
            foreach (var ordemServico in ordemServicos)
            {
                ordemServico.SolicitanteOs = SelectData.PesquisarSolicitanteId(ordemServico.SolicitanteOs.Id);
                ordemServico.MaquinaOs = SelectData.PesquisarMaquinaId(ordemServico.MaquinaOs.Id);
                ordemServico.SetorOs = SelectData.PesquisarSetorId(ordemServico.SetorOs.Id);
                ordemServico.SetorOs.SecretariaStr = SelectData.PesquisarSecretariaId(ordemServico.SetorOs.SecretariaStr.Id);
                ordemServico.AtendenteOs = SelectData.PesquisarAtendenteId(ordemServico.AtendenteOs.Id);
                this.ordemServicoBindingSource.Add(ordemServico);
                this.rprtvSetor.RefreshReport();
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            CriadorDateTimePickerHelper.SelecionaDateTimePicker(dtpInicio);
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            CriadorDateTimePickerHelper.SelecionaDateTimePicker(dtpFim);
        }
    }
}
