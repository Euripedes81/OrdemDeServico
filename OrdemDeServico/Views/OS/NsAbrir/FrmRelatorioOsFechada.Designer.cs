
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
            this.rptvOsFechada = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(OrdemDeServico.Model.OrdemServico);
            // 
            // FrmRelatorioOsFechada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.rptvOsFechada);
            this.Name = "FrmRelatorioOsFechada";
            this.Text = "FrmRelatorioOsFechada";
            this.Load += new System.EventHandler(this.FrmRelatorioOsFechada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvOsFechada;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
    }
}