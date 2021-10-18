
namespace OrdemDeServico.Views.OS.NsAbrir
{
    partial class FrmRelatorioOsFechada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioOsFechada));
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptvOsFechada = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(OrdemDeServico.Model.OrdemServico);
            // 
            // rptvOsFechada
            // 
            this.rptvOsFechada.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOrdemServico";
            reportDataSource1.Value = this.ordemServicoBindingSource;
            this.rptvOsFechada.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvOsFechada.LocalReport.ReportEmbeddedResource = "OrdemDeServico.Reports.RprtOsFechada.rdlc";
            this.rptvOsFechada.Location = new System.Drawing.Point(0, 0);
            this.rptvOsFechada.Name = "rptvOsFechada";
            this.rptvOsFechada.ServerReport.BearerToken = null;
            this.rptvOsFechada.Size = new System.Drawing.Size(984, 561);
            this.rptvOsFechada.TabIndex = 0;
            // 
            // FrmRelatorioOsFechada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.rptvOsFechada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorioOsFechada";
            this.Text = "Ordem de Serviço Fechada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioOsFechada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvOsFechada;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
    }
}