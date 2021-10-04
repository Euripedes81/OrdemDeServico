
namespace OrdemDeServico.Views.OS.NsAbrir
{
    partial class FrmRelatorioOsAberta
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
            this.rprtvOsAberta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rprtvOsAberta
            // 
            this.rprtvOsAberta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOrdemServico";
            reportDataSource1.Value = this.ordemServicoBindingSource;
            this.rprtvOsAberta.LocalReport.DataSources.Add(reportDataSource1);
            this.rprtvOsAberta.LocalReport.ReportEmbeddedResource = "OrdemDeServico.Reports.RprtOsAberta.rdlc";
            this.rprtvOsAberta.Location = new System.Drawing.Point(0, 0);
            this.rprtvOsAberta.Name = "rprtvOsAberta";
            this.rprtvOsAberta.ServerReport.BearerToken = null;
            this.rprtvOsAberta.Size = new System.Drawing.Size(800, 450);
            this.rprtvOsAberta.TabIndex = 0;
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(OrdemDeServico.Model.OrdemServico);
            // 
            // FrmRelatorioOsAberta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rprtvOsAberta);
            this.Name = "FrmRelatorioOsAberta";
            this.Text = "FrmRelatorioOsAberta";
            this.Load += new System.EventHandler(this.FrmRelatorioOsAberta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtvOsAberta;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
    }
}